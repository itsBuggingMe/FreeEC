using System;
using System.Linq;
using System.Text;

string typeDef = "Entity{name}<{u_def}{d_def}>";

string template = //we can use agressive optimisation and inlining here because jit knows at runtime and its a simple true/false or offset
"""
internal sealed class {type_def}({u_name}{d_name}) : IEntity<{type_def}>{u_con}{d_con}
{
{u_field}{d_field}

    public void Update(GameTime gameTime)
    {
{u_tick}
    }
    public void Draw()
    {
{d_tick}
    }

    [MethodImpl(AggOpt)]
    public ref T Get<T>() where T : IComponent
    {
{u_get}
{d_get}
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool Has<T>() where T : IComponent
    {
{u_has}
{d_has}
        return false;
    }

    public IEnumerable<IComponent> EnumerateComponents()
    {
{u_numerate}
{d_numerate}
    }
}


""";

string method = """
public IEntity Create<{u_def}{d_def}>({u_name}{d_name}){u_con}{d_con}
=> Register(new {type_def}({u_param}{d_param}));
""";

const string Seed = """
using Microsoft.Xna.Framework;
using static FreeEC.Helpers;
using System.Runtime.CompilerServices;

namespace FreeEC;


""";

StringBuilder total = new(Seed);
StringBuilder methodString = new();
StringBuilder arrString = new();

for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        total.Append(Replace(i, j));
        int genargcnt = i + j;
        arrString.Append($"typeof(Entity{i}{j}<{new string(Enumerable.Repeat(',', Math.Max(genargcnt - 1, 0)).ToArray())}>), ");
    }
}

Console.WriteLine(total);
Console.WriteLine(arrString);
Console.WriteLine(methodString);

string Replace(int ucount, int dcount)
{
    //def, name, con, tick, get, has

    string typeName = typeDef
        .Replace("{name}", $"{ucount}{dcount}")
        .Replace("{u_def}", BuildPattern(ucount, i => $"Tu{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_def}", BuildPattern(dcount, i => $"Td{i}, ", 2));

    string u_def = BuildPattern(ucount, i => $"Tu{i}, ", dcount == 0 ? 2 : 0);

    string m = method
        .Replace("{type_def}", typeName)
        .Replace("{u_def}", BuildPattern(ucount, i => $"Tu{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_def}", BuildPattern(dcount, i => $"Td{i}, ", 2))
        .Replace("{u_name}", BuildPattern(ucount, i => $"Tu{i} u{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_name}", BuildPattern(dcount, i => $"Td{i} d{i}, ", 2))
        .Replace("{u_con}", BuildPattern(ucount, i => $"\n    where Tu{i} : IUpdateComponent"))
        .Replace("{d_con}", BuildPattern(dcount, i => $"\n    where Td{i} : IDrawComponent"))
        .Replace("{u_param}", BuildPattern(ucount, i => $"u{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_param}", BuildPattern(dcount, i => $"d{i}, ", 2));

    methodString.Append('\n').Append('\n').Append(m);

    return template
        .Replace("{type_def}", typeName)
        .Replace("{u_name}", BuildPattern(ucount, i => $"in Tu{i} u{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_name}", BuildPattern(dcount, i => $"in Td{i} d{i}, ", 2))
        .Replace("{u_field}", BuildPattern(ucount, i => $"    Tu{i} _u{i} = u{i};\n"))
        .Replace("{d_field}", BuildPattern(dcount, i => $"    Td{i} _d{i} = d{i};\n", 1))
        .Replace("{u_con}", BuildPattern(ucount, i => $"\n    where Tu{i} : IUpdateComponent"))
        .Replace("{d_con}", BuildPattern(dcount, i => $"\n    where Td{i} : IDrawComponent"))
        .Replace("{u_tick}", BuildPattern(ucount, i => $"        _u{i}.Update(new EntC<{typeName}>(this), gameTime);\n", 1))
        .Replace("{d_tick}", BuildPattern(dcount, i => $"        _d{i}.Draw(new EntC<{typeName}>(this));\n", 1))
        .Replace("{u_get}", BuildPattern(ucount, i => $"        if(_u{i} is T)\n            return ref Unsafe.As<Tu{i}, T>(ref _u{i});\n", 1))
        .Replace("{d_get}", BuildPattern(dcount, i => $"        if(_d{i} is T)\n            return ref Unsafe.As<Td{i}, T>(ref _d{i});\n", 1))
        .Replace("{u_has}", BuildPattern(ucount, i => $"        if(_u{i} is T)\n            return true;\n", 1))
        .Replace("{d_has}", BuildPattern(dcount, i => $"        if(_d{i} is T)\n            return true;\n", 1))
        .Replace("{u_numerate}", BuildPattern(ucount, i => $"        yield return _u{i};\n"))
        .Replace("{d_numerate}", BuildPattern(dcount, i => $"        yield return _d{i};\n", 1))
        ;
}

string BuildPattern(int count, Func<int, string> modifier, int removeamt = 0)
{
    StringBuilder s = new();
    for (int i = 0; i < count; i++)
    {
        s.Append(modifier(i));
    }

    if (removeamt != 0 && count != 0)
    {
        s.Remove(s.Length - removeamt, removeamt);
    }

    string s1 = s.ToString();
    return s1;
}
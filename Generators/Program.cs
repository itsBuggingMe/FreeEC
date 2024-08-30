using System;
using System.Linq;
using System.Text;

string template =
"""
internal class Entity{name}<{u_def}{d_def}>({u_name}{d_name}) : IEntity{u_con}{d_con}
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

    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
{u_get}
        return ref Throw_NoComponent<T>();
    }

    public bool HasUpdate<T>() where T : IUpdateComponent
    {
{u_has}
        return false;
    }

    public ref T GetDraw<T>() where T : IDrawComponent
    {
{d_get}
        return ref Throw_NoComponent<T>();
    }

    public bool HasDraw<T>() where T : IDrawComponent
    {
{d_has}
        return false;
    }
}


""";

const string Seed = """
using Microsoft.Xna.Framework;
using static FreeEC.Helpers;
using System.Runtime.CompilerServices;

namespace FreeEC;


""";

StringBuilder total = new(Seed);
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

string Replace(int ucount, int dcount)
{
    //def, name, con, tick, get, has

    return template
        .Replace("{name}", $"{ucount}{dcount}")
        .Replace("{u_def}", BuildPattern(ucount, i => $"Tu{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_def}", BuildPattern(dcount, i => $"Td{i}, ", 2))
        .Replace("{u_name}", BuildPattern(ucount, i => $"Tu{i} u{i}, ", dcount == 0 ? 2 : 0))
        .Replace("{d_name}", BuildPattern(dcount, i => $"Td{i} d{i}, ", 2))
        .Replace("{u_field}", BuildPattern(ucount, i => $"    Tu{i} _u{i} = u{i};\n"))
        .Replace("{d_field}", BuildPattern(dcount, i => $"    Td{i} _d{i} = d{i};\n", 1))
        .Replace("{u_con}", BuildPattern(ucount, i => $"\n    where Tu{i} : IUpdateComponent"))
        .Replace("{d_con}", BuildPattern(dcount, i => $"\n    where Td{i} : IDrawComponent"))
        .Replace("{u_tick}", BuildPattern(ucount, i => $"        _u{i}.Update(this, gameTime);\n", 1))
        .Replace("{d_tick}", BuildPattern(dcount, i => $"        _d{i}.Draw(this);\n", 1))
        .Replace("{u_get}", BuildPattern(ucount, i => $"        if(_u{i} is T)\n            return ref Unsafe.As<Tu{i}, T>(ref _u{i});\n", 1))
        .Replace("{d_get}", BuildPattern(dcount, i => $"        if(_d{i} is T)\n            return ref Unsafe.As<Td{i}, T>(ref _d{i});\n", 1))
        .Replace("{u_has}", BuildPattern(ucount, i => $"        if(_u{i} is T)\n            return true;\n", 1))
        .Replace("{d_has}", BuildPattern(dcount, i => $"        if(_d{i} is T)\n            return true;\n", 1))
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

    return s.ToString();
}
using Microsoft.Xna.Framework;
using static FreeEC.Helpers;
using System.Runtime.CompilerServices;

namespace FreeEC;

internal sealed class Entity00() : IEntity<Entity00>
{


    public void Update(GameTime gameTime)
    {

    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {

        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity01<Td0>(in Td0 d0) : IEntity<Entity01<Td0>>
    where Td0 : IDrawComponent
{
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {

    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity01<Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {

        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity02<Td0, Td1>(in Td0 d0, in Td1 d1) : IEntity<Entity02<Td0, Td1>>
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {

    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity02<Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity02<Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {

        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity03<Td0, Td1, Td2>(in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity03<Td0, Td1, Td2>>
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {

    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity03<Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity03<Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity03<Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {

        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}

internal sealed class Entity10<Tu0>(in Tu0 u0) : IEntity<Entity10<Tu0>>
    where Tu0 : IUpdateComponent
{
    Tu0 _u0 = u0;


    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity10<Tu0>>(this), gameTime);
    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity11<Tu0, Td0>(in Tu0 u0, in Td0 d0) : IEntity<Entity11<Tu0, Td0>>
    where Tu0 : IUpdateComponent
    where Td0 : IDrawComponent
{
    Tu0 _u0 = u0;
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity11<Tu0, Td0>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity11<Tu0, Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity12<Tu0, Td0, Td1>(in Tu0 u0, in Td0 d0, in Td1 d1) : IEntity<Entity12<Tu0, Td0, Td1>>
    where Tu0 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Tu0 _u0 = u0;
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity12<Tu0, Td0, Td1>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity12<Tu0, Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity12<Tu0, Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity13<Tu0, Td0, Td1, Td2>(in Tu0 u0, in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity13<Tu0, Td0, Td1, Td2>>
    where Tu0 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Tu0 _u0 = u0;
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity13<Tu0, Td0, Td1, Td2>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity13<Tu0, Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity13<Tu0, Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity13<Tu0, Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}

internal sealed class Entity20<Tu0, Tu1>(in Tu0 u0, in Tu1 u1) : IEntity<Entity20<Tu0, Tu1>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;


    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity20<Tu0, Tu1>>(this), gameTime);
        _u1.Update(new EntC<Entity20<Tu0, Tu1>>(this), gameTime);
    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity21<Tu0, Tu1, Td0>(in Tu0 u0, in Tu1 u1, in Td0 d0) : IEntity<Entity21<Tu0, Tu1, Td0>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Td0 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity21<Tu0, Tu1, Td0>>(this), gameTime);
        _u1.Update(new EntC<Entity21<Tu0, Tu1, Td0>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity21<Tu0, Tu1, Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity22<Tu0, Tu1, Td0, Td1>(in Tu0 u0, in Tu1 u1, in Td0 d0, in Td1 d1) : IEntity<Entity22<Tu0, Tu1, Td0, Td1>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity22<Tu0, Tu1, Td0, Td1>>(this), gameTime);
        _u1.Update(new EntC<Entity22<Tu0, Tu1, Td0, Td1>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity22<Tu0, Tu1, Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity22<Tu0, Tu1, Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity23<Tu0, Tu1, Td0, Td1, Td2>(in Tu0 u0, in Tu1 u1, in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity23<Tu0, Tu1, Td0, Td1, Td2>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity23<Tu0, Tu1, Td0, Td1, Td2>>(this), gameTime);
        _u1.Update(new EntC<Entity23<Tu0, Tu1, Td0, Td1, Td2>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity23<Tu0, Tu1, Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity23<Tu0, Tu1, Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity23<Tu0, Tu1, Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}

internal sealed class Entity30<Tu0, Tu1, Tu2>(in Tu0 u0, in Tu1 u1, in Tu2 u2) : IEntity<Entity30<Tu0, Tu1, Tu2>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;


    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity30<Tu0, Tu1, Tu2>>(this), gameTime);
        _u1.Update(new EntC<Entity30<Tu0, Tu1, Tu2>>(this), gameTime);
        _u2.Update(new EntC<Entity30<Tu0, Tu1, Tu2>>(this), gameTime);
    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity31<Tu0, Tu1, Tu2, Td0>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Td0 d0) : IEntity<Entity31<Tu0, Tu1, Tu2, Td0>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Td0 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity31<Tu0, Tu1, Tu2, Td0>>(this), gameTime);
        _u1.Update(new EntC<Entity31<Tu0, Tu1, Tu2, Td0>>(this), gameTime);
        _u2.Update(new EntC<Entity31<Tu0, Tu1, Tu2, Td0>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity31<Tu0, Tu1, Tu2, Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity32<Tu0, Tu1, Tu2, Td0, Td1>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Td0 d0, in Td1 d1) : IEntity<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>(this), gameTime);
        _u1.Update(new EntC<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>(this), gameTime);
        _u2.Update(new EntC<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity32<Tu0, Tu1, Tu2, Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this), gameTime);
        _u1.Update(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this), gameTime);
        _u2.Update(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}

internal sealed class Entity40<Tu0, Tu1, Tu2, Tu3>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3) : IEntity<Entity40<Tu0, Tu1, Tu2, Tu3>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;


    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity40<Tu0, Tu1, Tu2, Tu3>>(this), gameTime);
        _u1.Update(new EntC<Entity40<Tu0, Tu1, Tu2, Tu3>>(this), gameTime);
        _u2.Update(new EntC<Entity40<Tu0, Tu1, Tu2, Tu3>>(this), gameTime);
        _u3.Update(new EntC<Entity40<Tu0, Tu1, Tu2, Tu3>>(this), gameTime);
    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity41<Tu0, Tu1, Tu2, Tu3, Td0>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Td0 d0) : IEntity<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Td0 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>(this), gameTime);
        _u1.Update(new EntC<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>(this), gameTime);
        _u2.Update(new EntC<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>(this), gameTime);
        _u3.Update(new EntC<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity41<Tu0, Tu1, Tu2, Tu3, Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Td0 d0, in Td1 d1) : IEntity<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this), gameTime);
        _u1.Update(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this), gameTime);
        _u2.Update(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this), gameTime);
        _u3.Update(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this), gameTime);
        _u1.Update(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this), gameTime);
        _u2.Update(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this), gameTime);
        _u3.Update(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}

internal sealed class Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Tu4 u4) : IEntity<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Tu4 : IUpdateComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Tu4 _u4 = u4;


    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>(this), gameTime);
        _u1.Update(new EntC<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>(this), gameTime);
        _u2.Update(new EntC<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>(this), gameTime);
        _u3.Update(new EntC<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>(this), gameTime);
        _u4.Update(new EntC<Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>>(this), gameTime);
    }
    public void Draw()
    {

    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        if (_u4 is T)
            return ref Unsafe.As<Tu4, T>(ref _u4);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        if (_u4 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {

        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {

        return false;
    }
}

internal sealed class Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Tu4 u4, in Td0 d0) : IEntity<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Tu4 : IUpdateComponent
    where Td0 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Tu4 _u4 = u4;
    Td0 _d0 = d0;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this), gameTime);
        _u1.Update(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this), gameTime);
        _u2.Update(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this), gameTime);
        _u3.Update(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this), gameTime);
        _u4.Update(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        if (_u4 is T)
            return ref Unsafe.As<Tu4, T>(ref _u4);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        if (_u4 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        return false;
    }
}

internal sealed class Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Tu4 u4, in Td0 d0, in Td1 d1) : IEntity<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Tu4 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Tu4 _u4 = u4;
    Td0 _d0 = d0;
    Td1 _d1 = d1;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this), gameTime);
        _u1.Update(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this), gameTime);
        _u2.Update(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this), gameTime);
        _u3.Update(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this), gameTime);
        _u4.Update(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this));
        _d1.Draw(new EntC<Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        if (_u4 is T)
            return ref Unsafe.As<Tu4, T>(ref _u4);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        if (_u4 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        return false;
    }
}

internal sealed class Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>(in Tu0 u0, in Tu1 u1, in Tu2 u2, in Tu3 u3, in Tu4 u4, in Td0 d0, in Td1 d1, in Td2 d2) : IEntity<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>
    where Tu0 : IUpdateComponent
    where Tu1 : IUpdateComponent
    where Tu2 : IUpdateComponent
    where Tu3 : IUpdateComponent
    where Tu4 : IUpdateComponent
    where Td0 : IDrawComponent
    where Td1 : IDrawComponent
    where Td2 : IDrawComponent
{
    Tu0 _u0 = u0;
    Tu1 _u1 = u1;
    Tu2 _u2 = u2;
    Tu3 _u3 = u3;
    Tu4 _u4 = u4;
    Td0 _d0 = d0;
    Td1 _d1 = d1;
    Td2 _d2 = d2;

    public void Update(GameTime gameTime)
    {
        _u0.Update(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this), gameTime);
        _u1.Update(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this), gameTime);
        _u2.Update(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this), gameTime);
        _u3.Update(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this), gameTime);
        _u4.Update(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this), gameTime);
    }
    public void Draw()
    {
        _d0.Draw(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this));
        _d1.Draw(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this));
        _d2.Draw(new EntC<Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>>(this));
    }

    [MethodImpl(AggOpt)]
    public ref T GetUpdate<T>() where T : IUpdateComponent
    {
        if (_u0 is T)
            return ref Unsafe.As<Tu0, T>(ref _u0);
        if (_u1 is T)
            return ref Unsafe.As<Tu1, T>(ref _u1);
        if (_u2 is T)
            return ref Unsafe.As<Tu2, T>(ref _u2);
        if (_u3 is T)
            return ref Unsafe.As<Tu3, T>(ref _u3);
        if (_u4 is T)
            return ref Unsafe.As<Tu4, T>(ref _u4);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasUpdate<T>() where T : IUpdateComponent

    {
        if (_u0 is T)
            return true;
        if (_u1 is T)
            return true;
        if (_u2 is T)
            return true;
        if (_u3 is T)
            return true;
        if (_u4 is T)
            return true;
        return false;
    }

    [MethodImpl(AggOpt)]
    public ref T GetDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return ref Unsafe.As<Td0, T>(ref _d0);
        if (_d1 is T)
            return ref Unsafe.As<Td1, T>(ref _d1);
        if (_d2 is T)
            return ref Unsafe.As<Td2, T>(ref _d2);
        return ref Throw_NoComponent<T>();
    }

    [MethodImpl(AggOpt)]
    public bool HasDraw<T>() where T : IDrawComponent
    {
        if (_d0 is T)
            return true;
        if (_d1 is T)
            return true;
        if (_d2 is T)
            return true;
        return false;
    }
}
using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;
using static FreeEC.Helpers;

namespace FreeEC
{
    internal class Entity00() : IEntity
    {
        public void Update(GameTime gameTime)
        {

        }
        public void Draw()
        {

        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {

            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity01<Td0>(Td0 d0) : IEntity
        where Td0 : IDrawComponent
    {
        Td0 _d0 = d0;

        public void Update(GameTime gameTime)
        {

        }
        public void Draw()
        {
            _d0.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {

            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity02<Td0, Td1>(Td0 d0, Td1 d1) : IEntity
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
            _d0.Draw(this);
            _d1.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {

            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity03<Td0, Td1, Td2>(Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {

            return false;
        }

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

    internal class Entity10<Tu0>(Tu0 u0) : IEntity
        where Tu0 : IUpdateComponent
    {
        Tu0 _u0 = u0;


        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
        }
        public void Draw()
        {

        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity11<Tu0, Td0>(Tu0 u0, Td0 d0) : IEntity
        where Tu0 : IUpdateComponent
        where Td0 : IDrawComponent
    {
        Tu0 _u0 = u0;
        Td0 _d0 = d0;

        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity12<Tu0, Td0, Td1>(Tu0 u0, Td0 d0, Td1 d1) : IEntity
        where Tu0 : IUpdateComponent
        where Td0 : IDrawComponent
        where Td1 : IDrawComponent
    {
        Tu0 _u0 = u0;
        Td0 _d0 = d0;
        Td1 _d1 = d1;

        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity13<Tu0, Td0, Td1, Td2>(Tu0 u0, Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _u0.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            return false;
        }

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

    internal class Entity20<Tu0, Tu1>(Tu0 u0, Tu1 u1) : IEntity
        where Tu0 : IUpdateComponent
        where Tu1 : IUpdateComponent
    {
        Tu0 _u0 = u0;
        Tu1 _u1 = u1;


        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
        }
        public void Draw()
        {

        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            if (_u1 is T)
                return ref Unsafe.As<Tu1, T>(ref _u1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            if (_u1 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity21<Tu0, Tu1, Td0>(Tu0 u0, Tu1 u1, Td0 d0) : IEntity
        where Tu0 : IUpdateComponent
        where Tu1 : IUpdateComponent
        where Td0 : IDrawComponent
    {
        Tu0 _u0 = u0;
        Tu1 _u1 = u1;
        Td0 _d0 = d0;

        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            if (_u1 is T)
                return ref Unsafe.As<Tu1, T>(ref _u1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            if (_u1 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity22<Tu0, Tu1, Td0, Td1>(Tu0 u0, Tu1 u1, Td0 d0, Td1 d1) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            if (_u1 is T)
                return ref Unsafe.As<Tu1, T>(ref _u1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            if (_u1 is T)
                return true;
            return false;
        }

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity23<Tu0, Tu1, Td0, Td1, Td2>(Tu0 u0, Tu1 u1, Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

        public ref T GetUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return ref Unsafe.As<Tu0, T>(ref _u0);
            if (_u1 is T)
                return ref Unsafe.As<Tu1, T>(ref _u1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasUpdate<T>() where T : IUpdateComponent
        {
            if (_u0 is T)
                return true;
            if (_u1 is T)
                return true;
            return false;
        }

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

    internal class Entity30<Tu0, Tu1, Tu2>(Tu0 u0, Tu1 u1, Tu2 u2) : IEntity
        where Tu0 : IUpdateComponent
        where Tu1 : IUpdateComponent
        where Tu2 : IUpdateComponent
    {
        Tu0 _u0 = u0;
        Tu1 _u1 = u1;
        Tu2 _u2 = u2;


        public void Update(GameTime gameTime)
        {
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
        }
        public void Draw()
        {

        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity31<Tu0, Tu1, Tu2, Td0>(Tu0 u0, Tu1 u1, Tu2 u2, Td0 d0) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity32<Tu0, Tu1, Tu2, Td0, Td1>(Tu0 u0, Tu1 u1, Tu2 u2, Td0 d0, Td1 d1) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity33<Tu0, Tu1, Tu2, Td0, Td1, Td2>(Tu0 u0, Tu1 u1, Tu2 u2, Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

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

    internal class Entity40<Tu0, Tu1, Tu2, Tu3>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
        }
        public void Draw()
        {

        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity41<Tu0, Tu1, Tu2, Tu3, Td0>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Td0 d0) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity42<Tu0, Tu1, Tu2, Tu3, Td0, Td1>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Td0 d0, Td1 d1) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity43<Tu0, Tu1, Tu2, Tu3, Td0, Td1, Td2>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

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

    internal class Entity50<Tu0, Tu1, Tu2, Tu3, Tu4>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Tu4 u4) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
            _u4.Update(this, gameTime);
        }
        public void Draw()
        {

        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {

            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {

            return false;
        }
    }

    internal class Entity51<Tu0, Tu1, Tu2, Tu3, Tu4, Td0>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Tu4 u4, Td0 d0) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
            _u4.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            return false;
        }
    }

    internal class Entity52<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Tu4 u4, Td0 d0, Td1 d1) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
            _u4.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
        }

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

        public ref T GetDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return ref Unsafe.As<Td0, T>(ref _d0);
            if (_d1 is T)
                return ref Unsafe.As<Td1, T>(ref _d1);
            return ref Throw_NoComponent<T>();
        }

        public bool HasDraw<T>() where T : IDrawComponent
        {
            if (_d0 is T)
                return true;
            if (_d1 is T)
                return true;
            return false;
        }
    }

    internal class Entity53<Tu0, Tu1, Tu2, Tu3, Tu4, Td0, Td1, Td2>(Tu0 u0, Tu1 u1, Tu2 u2, Tu3 u3, Tu4 u4, Td0 d0, Td1 d1, Td2 d2) : IEntity
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
            _u0.Update(this, gameTime);
            _u1.Update(this, gameTime);
            _u2.Update(this, gameTime);
            _u3.Update(this, gameTime);
            _u4.Update(this, gameTime);
        }
        public void Draw()
        {
            _d0.Draw(this);
            _d1.Draw(this);
            _d2.Draw(this);
        }

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
}
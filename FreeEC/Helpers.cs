using Microsoft.Xna.Framework;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

[assembly : InternalsVisibleTo("Tester")]
namespace FreeEC
{
    internal static class Helpers
    {
        public const MethodImplOptions AggOpt = MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization;

        [DoesNotReturn]
        public static ref T Throw_NoComponent<T>()
            => throw new InvalidOperationException($"Object does not have component of type {typeof(T).Name}");

        public static readonly Type[][] GenTypeMap =
        [
            [typeof(Entity00), typeof(Entity01<>), typeof(Entity02<,>), typeof(Entity03<,,>),                     ],
            [typeof(Entity10<>), typeof(Entity11<,>), typeof(Entity12<,,>), typeof(Entity13<,,,>),                ],
            [typeof(Entity20<,>), typeof(Entity21<,,>), typeof(Entity22<,,,>), typeof(Entity23<,,,,>),            ],
            [typeof(Entity30<,,>), typeof(Entity31<,,,>), typeof(Entity32<,,,,>), typeof(Entity33<,,,,,>),        ],
            [typeof(Entity40<,,,>), typeof(Entity41<,,,,>), typeof(Entity42<,,,,,>), typeof(Entity43<,,,,,,>),    ],
            [typeof(Entity50<,,,,>), typeof(Entity51<,,,,,>), typeof(Entity52<,,,,,,>), typeof(Entity53<,,,,,,,>),],
        ];

        //entity container
        //i dont trust the jit to inline this
        //it should since its all just calling the internal class
        [method: MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal struct EntC<T>(T value) : IEntity<EntC<T>>
            where T : IEntity<T>
        {
            private readonly T _internal = value;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly void Draw()
            {
                _internal.Draw();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref T1 GetDraw<T1>() where T1 : IDrawComponent
            {
                return ref _internal.GetDraw<T1>();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly ref T1 GetUpdate<T1>() where T1 : IUpdateComponent
            {
                return ref _internal.GetUpdate<T1>();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool HasDraw<T1>() where T1 : IDrawComponent
            {
                return _internal.HasDraw<T1>();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly bool HasUpdate<T1>() where T1 : IUpdateComponent
            {
                return _internal.HasUpdate<T1>();
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public readonly void Update(GameTime gameTime)
            {
                _internal.Update(gameTime);
            }
        }
    }
}
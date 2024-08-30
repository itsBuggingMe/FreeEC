namespace FreeEC
{
    internal class Helpers
    {
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
    }
}
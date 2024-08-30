using Microsoft.Xna.Framework;

namespace FreeEC;

internal struct TagComponent : IUpdateComponent
{
    //this is readonly as it is the key used in the world dictionary
    //HOWEVER, it does not prevent the struct from being reassigned
    public readonly object? Value;
    public object Meta;
    public readonly void Update<T>(T parent, GameTime gameTime) where T : IEntity<T> { }
}

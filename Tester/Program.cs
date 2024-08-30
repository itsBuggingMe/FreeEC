using FreeEC;
using Microsoft.Xna.Framework;
using System;
using Tester;

internal class Program
{
    public static void Main()
    {
        using var game = new GameRoot();
        game.Run();
    }
}
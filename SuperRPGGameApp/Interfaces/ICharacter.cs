﻿namespace SuperRPGGameApp.Interfaces
{
    public interface ICharacter : IAttack, IDestroyable
    {
        string Name { get; }

        Position Position { get; }
    }
}

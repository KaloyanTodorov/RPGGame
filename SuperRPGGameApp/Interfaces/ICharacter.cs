namespace SuperRPGGameApp.Interfaces
{
    // Extend-ване на интерфейс

    public interface ICharacter : IAttack, IDestroyable
    {
        string Name { get; }

        Position Position { get; }
    }
}

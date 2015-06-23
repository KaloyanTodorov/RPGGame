namespace SuperRPGGameApp.Interfaces
{
    using Characters;

    public interface IAttack
    {
        int Damage { get; }

        void Attack(Character enemy);

    }
}

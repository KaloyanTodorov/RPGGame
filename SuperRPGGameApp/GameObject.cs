using System;

namespace SuperRPGGameApp
{
    public abstract class GameObject
    {
        private int health;
        private int damage;

        protected GameObject(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The health cannot be negative!");
                }
                this.health = value;
            }
        }

        public int Damage
        {
            get { return this.damage; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The damage cannot be negative!");
                }
                this.damage = value;
            }
        }
    }
}

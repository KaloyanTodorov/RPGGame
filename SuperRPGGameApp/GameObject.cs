using SuperRPGGameApp.Exception;

namespace SuperRPGGameApp
{
    public abstract class GameObject
    {
        private Position position;
        private char objectSymbol;
        private int health;
        private int damage;

        protected GameObject(Position position, char objectSymbol)
        {
            this.Position = position;
            this.ObjectSymbol = objectSymbol;
        }

        public GameObject(int health, int damage)
        {
            // TODO: Complete member initialization
            this.health = health;
            this.damage = damage;
        }


        public Position Position
        {
            get { return this.position; }

            set
            {
                
                if (value.X < 0
                    || value.Y < 0
                    || value.X >= 59
                    || value.Y >= 30)
                {
<<<<<<< HEAD
                    throw new ArgumentException("Specified coordinates are outside map.");
=======
                    throw new RpgExceptions(Messages.InvalidHealth);
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
                }

                this.position = value;
            }
        }

        public char ObjectSymbol
        {
            get { return this.objectSymbol; }

            set
            {
                if (!char.IsUpper(value))
                {
<<<<<<< HEAD
                    throw new ArgumentOutOfRangeException(
                        "objectSymbol",
                        "Object symbol must be an upper-case letter.");
=======
                    throw new RpgExceptions(Messages.InvalidDamage);
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
                }

                this.objectSymbol = value;
            }
        }
    }
}

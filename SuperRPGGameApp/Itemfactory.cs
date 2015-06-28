using System;
using SuperRPGGameApp.Items;

namespace SuperRPGGameApp
{
    class ItemFactory
    {
        private readonly Random randomGenerator;

        public ItemFactory()
        {
            this.randomGenerator = new Random();
        }

        public void CreateItem()
        {
            int itemNumber = this.randomGenerator.Next(1,7);
            int x = this.randomGenerator.Next(1,60);
            int y = this.randomGenerator.Next(1,22);
            switch (itemNumber)
            {
                case 1:
                    var mastika = new Mastika(new Position(x, y));
                    break;
                case 2:
                    var musaka = new Musaka(new Position(x, y));
                    break;
                case 3:
                    var shnorhel = new Shnorhel(new Position(x, y));
                    break;
                case 4:
                    var turshia = new Turshia(new Position(x, y));
                    break;
                case 5:
                    var vibrator = new Vibrator(new Position(x, y));
                    break;
                case 6:
                    var vydica = new Vydica(new Position(x, y));
                    break;
            }
        }
    }
}

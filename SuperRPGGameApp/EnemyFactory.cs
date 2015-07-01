using System;
using SuperRPGGameApp.Characters;
using SuperRPGGameApp.Characters.Enemies;

namespace SuperRPGGameApp
{
    public class EnemyFactory
    {
        private readonly Random randomGenerator;

        public EnemyFactory()
        {
            this.randomGenerator = new Random();
        }

        public void CreateEnemy()
        {
            int enemyNumber = this.randomGenerator.Next(1,6);
            int x = this.randomGenerator.Next(1,60);
            int y = this.randomGenerator.Next(1,22);
            switch (enemyNumber)
            {
                case 1:
                    var azis = new Azis(new Position(x,y));
                    break;
                case 2:
                    var lili = new LiliIvanova(new Position(x, y));
                    break;
                case 3:
                    var mitio = new MitioPishtova(new Position(x, y));
                    break;
                case 4:
                    var vuchkov = new ProfesorVuchkov(new Position(x, y));
                    break;
                case 5:
                    var bojinka = new ValeriBojinov(new Position(x, y));
                    break;
            }
            Console.Write("E");
        }
    }
}

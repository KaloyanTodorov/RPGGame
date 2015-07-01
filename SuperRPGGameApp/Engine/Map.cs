using System;

namespace SuperRPGGameApp.Engine
{
   public static class Map
    {
       
        private const int numRows = 20;
        private const string stars = "************************************************************";
        private const string starsIn = "*                                                          *";
        public static void PrintMap()
        {
            Console.WriteLine(stars);
            for (int i = 0; i < numRows; i++)
            {
                Console.WriteLine(starsIn);
            }
            Console.WriteLine(stars);
            //var enemyFac = new EnemyFactory();
            //enemyFac.CreateEnemy();
        }
    }
}

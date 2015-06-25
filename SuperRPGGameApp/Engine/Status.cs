using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRPGGameApp.Characters;

namespace SuperRPGGameApp.Engine
{
    public static class Status
    {
        static Player newP = new Player(PlayerRace.Gaidar);
        private const int numRows = 20;
        private const string stars = "************************************************************";
        private const string starsIn = "*                                                          *";
        public static void PrintStatus()
        {
          
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("*\t"+newP);
                }
                else
                {
                    Console.WriteLine(starsIn);
                }
            }
            Console.WriteLine(stars);

        }
    }
}

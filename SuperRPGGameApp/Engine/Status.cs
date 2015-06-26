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
        static Player newP = new Player(PlayerRace.Spinderman);
        private const int numRows = 20;
        private static string stars = new string('*',60);
        private const string starsIn = "*                                                          *";
        public static void PrintStatus()
        {
            int count = newP.ToString().Length;

            string input = new string(' ',(60-8-count-1));
            input += "*";
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("*\t"+newP+input);
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

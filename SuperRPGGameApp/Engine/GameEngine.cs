using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperRPGGameApp.Characters;

namespace SuperRPGGameApp.Engine
{
    public static class GameEngine
    {
        public static void Run()
        {
            Player newP = new Player(PlayerRace.Spinderman);
            Move.ExecuteCommand(new ConsoleKeyInfo());
          
        }
    }
}

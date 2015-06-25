using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRPGGameApp.Engine
{
    public static class GameEngine
    {
        public static void Run()
        {
            Move.ExecuteCommand(new ConsoleKeyInfo());
        }
    }
}

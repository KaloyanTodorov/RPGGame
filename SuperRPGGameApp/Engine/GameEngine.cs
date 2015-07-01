using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SuperRpgGame.Attributes;
=======
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
using SuperRPGGameApp.Characters;
using SuperRPGGameApp.Interfaces;
using SuperRPGGameApp.Items;

namespace SuperRPGGameApp.Engine
{
    public  class GameEngine
    {
        public bool IsRunning { get; private set; }

        private readonly IList<GameObject> characters;
        private  readonly Random Rand = new Random();
        private readonly IList<GameObject> items;
        private readonly string[] characterNames =
        {
            "Gosho",
            "peshoo",
            "kiro"
           
        };
        private Player player;
        
        public GameEngine()
        {
           this.items=new List<GameObject>();
            this.characters = new List<GameObject>();
            
        }
        public void Run()
        {
          //  Map.PrintMap();
         
            this.IsRunning = true;
           var playerName = "Koki";
            PlayerRace race = PlayerRace.Nakov;

            this.player = new Player(new Position(1, 1), 'N', playerName, race);

            this.PopulateEnemies();
            this.PopulateItems();
            
            while (this.IsRunning)
            {
                PrintMap();
                Move.ExecuteCommand(Console.ReadKey());
         
                if (this.characters.Count == 0)
                {
                    this.IsRunning = false;
                    Console.WriteLine("Valar morgulis!");
                }
            }
        }
        private  Item CreateItem()
        {
            int currentX = Rand.Next(1, 30);
            int currentY = Rand.Next(1, 20);

            bool containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

        

            while (containsEnemy)
            {
                currentX = Rand.Next(1,20);
                currentY = Rand.Next(1, 20);

                containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

              
            }

            return new Mastika(new Position(currentX, currentY));
        }

      

        private Enemy CreateEnemy()
        {
            int currentX = Rand.Next(1, 20);
            int currentY = Rand.Next(1, 20);

            bool containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);

            while (containsEnemy)
            {
                currentX = Rand.Next(1, 20);
                currentY = Rand.Next(1, 20);

                containsEnemy = this.characters
                .Any(e => e.Position.X == currentX && e.Position.Y == currentY);
            }

            int nameIndex = Rand.Next(0, 3);
            string name = this.characterNames[nameIndex];

            return new Enemy(new Position(currentX, currentY), 'J', name);

        }
        private void PopulateEnemies()
        {
<<<<<<< HEAD
            for (int i = 0; i < 10; i++)
            {
                Enemy enemy = this.CreateEnemy();
                this.characters.Add(enemy);
            }
=======
            Player newP = new Player(PlayerRace.Spinderman);
            Move.ExecuteCommand(new ConsoleKeyInfo());
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
        }
        private void PopulateItems()
        {
            for (int i = 0; i < 10; i++)
            {
                Item mastika = this.CreateItem();
                this.items.Add(mastika);
            }
        }

        private void PrintMap()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < 20; row++)
            {
                for (int col = 0; col < 30; col++)
                {
                    if (this.player.Position.X == col && this.player.Position.Y == row)
                    {
                        sb.Append('♣');
                        continue;
                    }

                    var character =
                         this.characters
                         .Cast<Enemy>()
                         .FirstOrDefault(c => c.Position.X == col
                             && c.Position.Y == row
                             && c.Health > 0);

                    var item = this.items
                        .Cast<Item>()
                        .FirstOrDefault(c => c.Position.X == col
                            && c.Position.Y == row
                            && c.ItemState == ItemState.Available);

                    if (character == null && item == null)
                    {
                        sb.Append(' ');
                    }
                    else if (character != null)
                    {
                      
                        sb.Append(character.ObjectSymbol);
                    }
                    else
                    {
                        sb.Append(item.ObjectSymbol);
                    }
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }

    }
}

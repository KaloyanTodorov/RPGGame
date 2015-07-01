using System;
using SuperRPGGameApp.Interfaces;
using SuperRPGGameApp.Items;

namespace SuperRPGGameApp.Characters
{
<<<<<<< HEAD
   using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Player : Character
    {
      
 
        public Player(Position position, char objectSymbol, string name, PlayerRace race)
            : base(position, objectSymbol, name, 1, 1)
=======
   
        public class Player : Character, ICollect
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3
        {
            this.Race = race;
            this.SetPlayerStats();
        }

        public PlayerRace Race { get; private set; }

<<<<<<< HEAD
   
       public override string ToString()
        {
            return string.Format(
                "Player {0} ({1}): Damage ({2}), Health ({3})",
                this.Name,
                this.Race,
                this.Damage,
                this.Health
                );
        }
=======
          
            public override string ToString()
            {
                return string.Format(
                    "Race: {0}, Damage: {1}, Health: {2}",
                   
                    this.Race,
                    this.Damage,
                    this.Health);
            }

            public void UseItem(Item item)
            {
            }
>>>>>>> e361981c8ad034c9971d16b7a3ec22b99d67c5a3

       
    
        private void SetPlayerStats()
            {
                switch (this.Race)
                {
                    case PlayerRace.Spinderman:
                        this.Damage = 300;
                        this.Health = 100;
                        break;
                    case PlayerRace.Kitarist:
                        this.Damage = 250;
                        this.Health = 150;
                        break;
                    case PlayerRace.Gaidar:
                        this.Damage = 350;
                        this.Health = 75;
                        break;
                    case PlayerRace.Nakov:
                        this.Damage = 200;
                        this.Health = 200;
                        break;
                    default:
                        throw new ArgumentException("Unknown player race.");
                }
            }
        }
    }

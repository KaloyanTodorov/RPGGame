using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRPGGameApp.Characters
{
   using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Items;

    public class Player : Character
    {
      
 
        public Player(Position position, char objectSymbol, string name, PlayerRace race)
            : base(position, objectSymbol, name, 1, 1)
        {
            this.Race = race;
            this.SetPlayerStats();
        }

        public PlayerRace Race { get; private set; }

   
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

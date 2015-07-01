using System;
using SuperRPGGameApp.Interfaces;
using SuperRPGGameApp.Items;

namespace SuperRPGGameApp.Characters
{
   
        public class Player : Character, ICollect
        {
           public Player(PlayerRace race)
                : base(0, 0)
            {
              this.Race = race;
              this.SetPlayerStats();
            }

            public PlayerRace Race { get; private set; }

          
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

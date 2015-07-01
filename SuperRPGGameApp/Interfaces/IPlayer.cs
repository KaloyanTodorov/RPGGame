using SuperRPGGameApp.Characters;

namespace SuperRPGGameApp.Interfaces
{
   
    public interface IPlayer : ICharacter
    {
        PlayerRace Race { get; }
    } 
    
}
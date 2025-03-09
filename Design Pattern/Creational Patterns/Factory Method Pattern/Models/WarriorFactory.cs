namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models
{
    public class WarriorFactory : IGameCharacterFactory
    {
        public IGameCharacter CreateCharacter()
        {
            return new Warrior();
        }
    }
}
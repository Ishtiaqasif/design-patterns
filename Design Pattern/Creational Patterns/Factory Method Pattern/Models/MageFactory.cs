namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models
{
    public class MageFactory : IGameCharacterFactory
    {
        public IGameCharacter CreateCharacter()
        {
            return new Mage();
        }
    }
}
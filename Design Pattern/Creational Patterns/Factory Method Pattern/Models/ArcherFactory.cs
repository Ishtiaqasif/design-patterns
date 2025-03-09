namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models
{
    public class ArcherFactory : IGameCharacterFactory
    {
        public IGameCharacter CreateCharacter()
        {
            return new Archer();
        }
    }
}
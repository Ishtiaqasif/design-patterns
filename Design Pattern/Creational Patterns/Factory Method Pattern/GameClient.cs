using Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models;

namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern
{
    public class GameClient
    {
        public void CreateCharacter(string characterType)
        {
            IGameCharacterFactory factory = null;

            // Decide which factory to use based on the character type
            if (characterType == "Warrior")
            {
                factory = new WarriorFactory();
            }
            else if (characterType == "Mage")
            {
                factory = new MageFactory();
            }
            else if (characterType == "Archer")
            {
                factory = new ArcherFactory();
            }

            // Create the appropriate game character using the factory
            IGameCharacter character = factory?.CreateCharacter();
            character?.Attack();
            character?.Defend();
        }
    }

}

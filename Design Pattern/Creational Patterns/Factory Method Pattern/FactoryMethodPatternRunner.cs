using Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models;

namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern
{
    internal static class FactoryMethodPatternRunner
    {
        public static void Run()
        {
            // Example of selecting the character type
            CreateCharacter("Warrior");   // Warrior attacks with sword! / Warrior defends with shield!
            CreateCharacter("Mage");      // Mage casts fireball! / Mage shields with magic barrier!
            CreateCharacter("Archer");    // Archer shoots an arrow! / Archer evades with agility!
        }

        public static void CreateCharacter(string characterType)
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
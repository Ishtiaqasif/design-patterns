namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern
{
    internal static class FactoryMethodPatternRunner
    {
        public static void Run()
        {
            GameClient client = new GameClient();

            // Example of selecting the character type
            client.CreateCharacter("Warrior");   // Warrior attacks with sword! / Warrior defends with shield!
            client.CreateCharacter("Mage");      // Mage casts fireball! / Mage shields with magic barrier!
            client.CreateCharacter("Archer");    // Archer shoots an arrow! / Archer evades with agility!

        }
    }
}
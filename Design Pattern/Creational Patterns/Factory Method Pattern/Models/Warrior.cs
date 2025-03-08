namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models
{
    internal class Warrior : IGameCharacter
    {
        public void Attack()
        {
            Console.WriteLine("Warrior attacks with sword!");
        }

        public void Defend()
        {
            Console.WriteLine("Warrior defends with a shield!");
        }
    }
}
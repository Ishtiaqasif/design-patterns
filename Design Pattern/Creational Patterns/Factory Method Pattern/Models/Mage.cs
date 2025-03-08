namespace Design_Pattern.Creational_Patterns.Factory_Method_Pattern.Models
{
    internal class Mage : IGameCharacter
    {
        public void Attack()
        {
            Console.WriteLine("Archer shoots an arrow!");
        }

        public void Defend()
        {
            Console.WriteLine("Archer evades with agility!");
        }
    }
}
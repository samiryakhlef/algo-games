namespace ConsoleGames
{
    public class Mage : Character, IResurrection, ISuperAttack
    {
        private int SpecialHitMage { get; }

        public Mage(string name = "Mage", int health = 100, int attack = 20, int defense = 25, int specialAttack = 70, int specialHitMage = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            this.SpecialHitMage = specialHitMage;
        }

        public void Resurrect(Character character)
        {
            // Implement the specific resurrection logic for the Mage
            Console.WriteLine("Mage resurrected {character.Name}");
        }

        public void SuperAttack(Character character)
        {
            // Implement the specific super attack for the Mage
            Console.WriteLine("Mage unleashed a powerful spell on {character.Name}");
        }
    }
}

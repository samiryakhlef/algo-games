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

        public int SuperAttack(Character character)
        {
            int increasedAttack = CalculateSuperAttack(character);
            Console.WriteLine("dommage totale de la super attack du mage: " + increasedAttack);
            return increasedAttack;
        }

        public void Resurrect(Character character)
        {
            // Implement the specific resurrection logic for the Mage
            Console.WriteLine("Mage resurrected {character.Name}");
        }
    }
}

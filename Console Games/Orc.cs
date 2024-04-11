namespace ConsoleGames
{
    public class Orc : Character, ISuperAttack, ISuperDefense
    {
        private int SpecialHitOrc { get; }

        public Orc(string name = "Orc", int health = 100, int attack = 20, int defense = 25, int specialAttack = 85, int specialHitOrc = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            this.SpecialHitOrc = specialHitOrc;
        }
        public int SuperAttack(Character character)
        {
            int increasedAttack = CalculateSuperAttack(character);
            Console.WriteLine("dommage totale de la super attack de l'orc: " + increasedAttack);
            return increasedAttack;
        }

        public void SuperDefense(Character character)
        {
            // Implement the specific super defense for the Orc
            Console.WriteLine("Orc activated powerful defense against {character.Name}");
        }
    }
}

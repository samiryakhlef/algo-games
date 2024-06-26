namespace ConsoleGames
{
    public class Human : Character, ISuperCounter, ISuperAttack
    {
        private int SpecialHitHuman { get; }

        public Human(string name = "Human", int health = 100, int attack = 20, int defense = 25, int specialAttack = 70, int specialHitHuman = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            this.SpecialHitHuman = specialHitHuman;
        }

        public void SuperCounter(Character character)
        {
            // Implement the specific super counter for the Human
            Console.WriteLine("Human performed a super counter against {character.Name}");
        }

        public int SuperAttack(Character character)
        {
            int increasedAttack = CalculateSuperAttack(character);
            Console.WriteLine("dommage totale de la super attack of human: " + increasedAttack);
            return increasedAttack;
        }
    }
}

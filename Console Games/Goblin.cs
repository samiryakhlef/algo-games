namespace ConsoleGames
{
    public class Goblin : Character, ISuperAttack, ISuperDefense
    {
        private int SpecialHitGoblin { get; }

        public Goblin(string name = "Goblin", int health = 100, int attack = 18, int defense = 2, int specialAttack = 85, int specialHitGoblin = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            SpecialHitGoblin = specialHitGoblin;
        }
        public int SuperAttack(Character character)
        {
            int increasedAttack = CalculateSuperAttack(character);
            Console.WriteLine("dommage totale de la super attack du goblin: " + increasedAttack);
            return increasedAttack;
        }

        public virtual void SuperDefense(Character character)
        {
            // Implement the specific super defense for the Goblin
            Console.WriteLine("Goblin activated super defense against ${character.Name}");
        }

    }
}


namespace ConsoleGames
{
    public class Goblin : Character,ISuperDefense
    {
        private int SpecialHitGoblin { get; }

        public Goblin(string name = "Goblin", int health = 100, int attack = 2, int defense = 2, int specialAttack = 85, int specialHitGoblin = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            SpecialHitGoblin = specialHitGoblin;
        }

        public int CalculateSuperAttack(Character defender)
        {
            double addAttackPercentage = 0.01;
            int baseDamage = Math.Max(0, Att - defender.Def);
            int increasedAttack = (int)(addAttackPercentage * baseDamage);
            return increasedAttack;
        }





        public virtual void SuperDefense(Character character)
        {
            int increasedDefenseTotal = CalculateSuperDefense(character);
            Console.WriteLine($"Goblin activated super defense: {increasedDefenseTotal}");
        }
    }
}


namespace ConsoleGames
{
    public class Orc : Character, ISuperAttack, ISuperDefense
    {
        private int SpecialHitOrc { get; }

        public Orc(string name = "Orc", int health = 100, int attack = 100, int defense = 25, int specialAttack = 85, int specialHitOrc = 55)
            : base(name, health, attack, defense, specialAttack)
        {
            this.SpecialHitOrc = specialHitOrc;
        }

        public int SuperAttack(Character character)
        {
            if (character == null)
            {
                throw new ArgumentNullException(nameof(character), "Le paramètre character ne doit pas être null.");
            }

            int increasedAttack = CalculateSuperAttack(character);
            Console.WriteLine($"Dommage total de la super attaque de l'orc: {increasedAttack}");
            return increasedAttack;
        }

        public void SuperDefense(Character character)
        {
            // Implémenter la défense super spécifique pour l'Orc
            Console.WriteLine($"L'Orc a activé une défense puissante contre {character.Name}");
        }

        public int CalculateSuperAttack(Character defender)
        {
            double addAttackPercentage = 0.01;
            int baseDamage = Math.Max(0, Att - defender.Def);
            int increasedAttack = (int)(addAttackPercentage * baseDamage);
            return increasedAttack;
        }
    }
}

namespace ConsoleGames
{
    public class Elf : Character, IResurrection, ISuperAttack
    {
        private int SpecialHitElf { get; }

        public Elf(string name = "Elf", int health = 100, int attack = 20, int defense = 25, int specialAttack = 70, int specialHitElf = 0)
            : base(name, health, attack, defense, specialAttack)
        {
            this.SpecialHitElf = specialHitElf;
        }

        public void Resurrect(Character character)
        {
            // Implementation for resurrecting a character
            Console.WriteLine("Elf resurrected {character.Name}");
        }

        public void SuperAttack(Character character)
        {
            // Implementation for performing a super attack on a character
            
        }
    }
}

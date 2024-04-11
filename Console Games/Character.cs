using System.ComponentModel.DataAnnotations;

namespace ConsoleGames;
public class Character
{
    public Guid Id { get; private set; }
    public virtual string Name { get; set; }
    public int MaxPv { get; private set; } // Consider separate max and current health
    public int Att { get; set; }
    public int Def { get; set; }
    public int SpecialAtt { get; set; }

    public int CurrentPv { get; private set; } // Make Pv read-only and set/modify through methods

    public Character(string name, int maxPv, int att, int def, int specialAtt)
    {
        Id = Guid.NewGuid();
        Name = name;
        MaxPv = CurrentPv = maxPv;
        Att = att;
        Def = def;
        SpecialAtt = specialAtt;
    }
    public int Attack(Character defender)
    {
        int baseDamage = Math.Max(0, Att - defender.Def);
        Random RandomDamage = new Random();
        int ResultRandomDamage = RandomDamage.Next(20);
        int damage = baseDamage + ResultRandomDamage;

        // Coup critique 
        if (CriticalHit(defender))
        {
            damage *= 2;
        }
        defender.TakeDamage(damage);
        return damage;
    }
    private static bool CriticalHit(Character defender)
    {
        int criticalHitChance = 10;
        Random randomNumber = new Random();
        int ResultRandomNumber = randomNumber.Next(0, 100);
        return ResultRandomNumber <= criticalHitChance;

    }

    public void TakeDamage(int damage)
    {
        CurrentPv = Math.Max(0, CurrentPv - damage);
    }

    public int CalculateSuperAttack(Character defender)
    {
        double addAttackPercentage = 0.45;

        int valueOfSuperAttack = (int)((addAttackPercentage * Attack(defender)));
        int increasedAttack = Math.Abs(valueOfSuperAttack - CurrentPv);

        return increasedAttack;
    }
}


// public void SuperDefenseP(Character defenseur)
// {
//     Console.WriteLine("Goblin super Defense parent");
//     // point de vie fixe perdue en cas du declenchement de SuperDéfense 
//     var fixedHitPointMalus = defenseur.Pv -= 20;

//     // bonus du bouclier
//     int malusPv = defenseur.Def / 2 + defenseur.Def / 2;


//     int shield = malusPv - fixedHitPointMalus;
// }


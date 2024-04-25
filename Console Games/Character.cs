using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleGames
{
    public class Character
    {
        private static readonly Random random = new Random();

        public Guid Id { get; }
        public string Name { get; set; }
        public int MaxPv { get; }
        public int Att { get; set; }
        public int Def { get; set; }
        public int SpecialAtt { get; set; }
        public int CurrentPv { get; private set; }
        public int Defense { get; internal set; }

        public Character(string name, int maxPv, int att, int def, int specialAtt)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Le nom du personnage ne peut pas être vide.");
            }

            if (maxPv <= 0 || att < 0 || def < 0 || specialAtt < 0)
            {
                throw new ArgumentException("Les valeurs des attributs doivent être positives.");
            }

            Id = Guid.NewGuid();
            Name = name;
            MaxPv = maxPv;
            CurrentPv = maxPv;
            Att = att;
            Def = def;
            SpecialAtt = specialAtt;
        }

        public int Attack(Character defender)
        {
            int baseDamage = Math.Max(0, Att - defender.Def);
            int resultRandomDamage = random.Next(20);
            int damage = baseDamage + resultRandomDamage;
            if (CriticalHit())
            {
                damage *= 2;
            }
            defender.TakeDamage(damage);
            return damage;
        }

        private static bool CriticalHit()
        {
            int criticalHitChance = 10;
            int resultRandomNumber = random.Next(0, 100);
            return resultRandomNumber <= criticalHitChance;
        }

        public void TakeDamage(int damage)
        {
            CurrentPv = Math.Max(0, CurrentPv - damage);
        }

        // public int CalculateSuperAttack(Character defender)
        // {
        //     double addAttackPercentage = 0.01;
        //     int baseDamage = Math.Max(0, Att - defender.Def);
        //     int increasedAttack = (int)(addAttackPercentage * baseDamage);
        //     return increasedAttack;
        // }

        public static int CalculateSuperDefense(Character character)
        {
            int increasedDefense = 10;
            if (character.CurrentPv <= 30)
            {
                return increasedDefense;
            }
            return 0;
        }
    }
}
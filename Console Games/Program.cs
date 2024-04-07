using System.Numerics;

class Character
{
    public string Classe { get; set; }
    public int Pv { get; set; }
    public int Att { get; set; }
    public int Def { get; set; }
    public string SpecialAtt { get; set; }

    public Character(string classe, int pv, int att, int def, string specialAtt)
    {
        Classe = classe;
        Pv = pv;
        Att = att;
        Def = def;
        SpecialAtt = specialAtt;
    }

    // Méthode pour simuler une attaque sur un personnage
    public void Attack(Character defenseur)
    {
        //Soustraire l'attaque du defenseur
        int resultatAttaque = Math.Max(0, Att - defenseur.Def);
        //Si le résultat est positif, on soustrait les PV du défenseur
        if (resultatAttaque > 0)
        {
            //Diminuer les PV du défenseur en fonction du résultatAttaque sur le defenseur
            defenseur.Pv -= resultatAttaque;
        }

        // gerer les PV  négatifs
        defenseur.Pv = Math.Max(0, defenseur.Pv - resultatAttaque);
    }
}

class App
{
    public static void Main(string[] args)
    {
        var characters = new List<Character>()
        {
            new Character("Goblin", 100, 25, 2, "Iron Axe"),
            new Character("Orc", 100, 35, 5, "Spear"),
            new Character("Humain", 150, 50, 1, "Ragnarok"),
            new Character("Mage", 100, 55, 2, "End of the World"),
            new Character("Elfe", 100, 85, 2, "Zoltrak")
        };

        Random random = new Random();

        // On simulation des combats aléatoires
        // Boucle tant qu'il reste au moins 2 personnages (0 et 1)
        while (characters.Count > 1)
        {
            int attaquantIndex = random.Next(characters.Count);
            int defenseurIndex = random.Next(characters.Count);
            //Console.WriteLine(attaquantIndex);

            // S'assurer que les index des attaquant et le défenseur ne sont pas les mêmes
            while (attaquantIndex == defenseurIndex)
            {
                defenseurIndex = random.Next(characters.Count);
            }

            // je passe la methode attaque à l'attaquant pour simuler l'attaque en passant en argument le defenseur
            characters[attaquantIndex].Attack(characters[defenseurIndex]);

            // on vérifie si le personnage à perdu tous ses PV
            if (characters[defenseurIndex].Pv <= 0)
            {
                // Affiche la valeur des attaques du personnage
                Console.WriteLine(characters[defenseurIndex].Classe + $" attaque de : {characters[defenseurIndex].Att}");

                // Stocke les points de vie perdus du personnage dans une variable
                int pointsDeViePerdu = characters[defenseurIndex].Pv;

                // Message indiquant les points de vie perdus par le personnage
                Console.WriteLine(characters[defenseurIndex].Classe + $" a perdu :" + pointsDeViePerdu + " PV !");

                // Affiche un message indiquant que le personnage a été vaincu
                Console.WriteLine($" {characters[defenseurIndex].Classe} a été vaincu !");

                // Supprime le personnage de la liste
                characters.RemoveAt(defenseurIndex);
            }
        }

        // Déclarer le vainqueur final
        Console.WriteLine($" Le vainqueur final est : {characters[0].Classe} !");
    }
}

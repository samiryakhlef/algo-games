namespace ConsoleGames;
class App
{
    public static void Main(string[] args)
    {
        var instanceGoblin = new Goblin("Goblin", 100, 25, 10, 75);
        instanceGoblin.Attack(new Goblin("Goblin", 100, 25, 10, 75));
        //instanceGoblin.SuperAttack(new Goblin("Goblin", 100, 25, 10, 75));
        Orc orc = new("Orc", 100, 25, 10, 75);
        orc.Attack(new Orc("Orc", 100, 25, 10, 75));
        orc.SuperAttack(new Orc("Orc", 100, 25, 10, 75));

        // var instanceHuman = new Human("Human", 100, 25, 10, 75);
        // instanceHuman.Attack(new Human("Human", 100, 25, 10, 75));
        // instanceHuman.SuperAttack(new Human("Human", 100, 25, 10, 75));

        // var instanceMage = new Mage("Mage", 100, 25, 10, 75);
        // instanceMage.Attack(new Mage("Mage", 100, 25, 10, 75));
        // instanceMage.SuperAttack(new Mage("Mage", 100, 25, 10, 75));

        // var instanceElfe = new Elf("Elfe", 100, 25, 10, 75);
        // instanceElfe.Attack(new Elf("Elfe", 100, 25, 10, 75));
        // instanceElfe.SuperAttack(new Elf("Elfe", 100, 25, 10, 75));

        Console.WriteLine("The goblin hits the opponent with: " + instanceGoblin.Attack(new Elf("Elfe", 100, 25, 10, 75)) + "\n");
        Console.WriteLine("The orc hits the opponent with: " + orc.Attack(new Elf("Elfe", 100, 25, 10, 75)) + "\n");
        // Console.WriteLine("The human hits the opponent with: " + instanceHuman.Attack(new Elf("Elfe", 100, 25, 10, 75))) + "\n";
        // Console.WriteLine("The mage hits the opponent with: " + instanceMage.Attack(new Elf("Elfe", 100, 25, 10, 75))) + "\n";
        // Console.WriteLine("The elf hits the opponent with: " + instanceElfe.Attack(new Elf("Elfe", 100, 25, 10, 75))) + "\n";

        //     var characters = new List<Character>()
        //     {
        //         new Goblin("Goblin", 100, 25, 10, 75),
        //         new Goblin("Goblin", 100, 25, 10, 75,20),
        //         new Orc(),
        //         new Humain(),
        //         new Mage(),
        //         new Elfe()
        //     };

        //     Random random = new Random();

        //     // On simulation des combats aléatoires
        //     // Boucle tant qu'il reste au moins 2 personnages (0 et 1)
        //     Character attaquant = characters[random.Next(characters.Count)];
        //     //Character defenseur = characters[random.Next(characters.Count)];

        //     var list = characters.Where(c => c.Id != attaquant.Id);
        //     Character defenseur = list.First();


        //     //Console.WriteLine(attaquant.Nom + " vs " + defenseur.Nom + "\n");

        //     // je passe la methode attaque à l'attaquant pour simuler l'attaque en passant en argument le defenseur
        //     attaquant.Attack(defenseur);

        //     // on passe la methode specialAtt de l'attaquant pour simuler la specialAtt en passant en argument le defenseur
        //     attaquant.SpecialAttack(defenseur);

        //     // on vérifie si le personnage à perdu tous ses PV
        //     if (defenseur.Pv <= 0)
        //     {

        //         // Affiche la valeur des attaques du personnage
        //         Console.WriteLine(defenseur.Nom + $" attaque de : {defenseur.Att} PV !");
        //         Console.WriteLine(defenseur.Nom + $" attaque speciale de : {defenseur.SpecialAtt} PV !");

        //         // Stocke les points de vie perdus du personnage dans une variable
        //         int pointsDeViePerdu = defenseur.Pv;

        //         if (pointsDeViePerdu <= 20)
        //         {
        //             // Affiche un message du combattant qui lance l'attaqueSpécial
        //             Console.WriteLine(defenseur.Nom + " a lancer une attaque speciale! et fait " + attaquant.SpecialAtt + " PV de dégat !");
        //         }

        //         // Message indiquant les points de vie perdus par le personnage
        //         Console.WriteLine(defenseur.Nom + $" a perdu : {defenseur.Pv - pointsDeViePerdu} PV !");

        //         // Affiche un message indiquant que le personnage a été vaincu
        //         Console.WriteLine($" {defenseur.Nom} a été vaincu !");

        //         // Supprime le personnage de la liste
        //         //characters.RemoveAt(defenseurIndex);

        //         // Déclarer le vainqueur final
        //         if (characters.Count > 0)
        //         {
        //             Console.WriteLine($" Le vainqueur final est : {characters[0].Nom} !");
        //         }
        //     }
    }
}

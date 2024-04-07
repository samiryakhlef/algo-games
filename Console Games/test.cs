// // Déclaration des classes et de la liste de personnages (identique au code précédent)

// // Fonction pour simuler un combat aléatoire
// void SimulerCombat(Personnage attaquant, Personnage defenseur)
// {
//     // ... Implémentation de la logique du combat
//     Console.WriteLine($"{attaquant.Classe} vs {defenseur.Classe}");
//     // ... Détermination du vainqueur et mise à jour des statistiques
// }

// // Simulation des combats aléatoires
// Random random = new Random();

// while (personnages.Count > 1) // Boucle tant qu'il reste au moins deux personnages
// {
//     int attackerIndex = random.Next(personnages.Count); // Attaquant aléatoire
//     int defenderIndex = random.Next(personnages.Count); // Défenseur aléatoire

//     while (attackerIndex == defenderIndex) // Eviter les combats entre un même personnage et lui-même
//     {
//         defenderIndex = random.Next(personnages.Count);
//     }

//     SimulerCombat(personnages[attackerIndex], personnages[defenderIndex]);

//     // Vérifier si un personnage a perdu tous ses PV
//     if (personnages[defenderIndex].Pv <= 0) // Condition modifiée pour inclure le cas PV = 0
//     {
//         Console.WriteLine($" Match {personnages.IndexOf(personnages[defenderIndex])} : {personnages[defenderIndex].Classe} a perdu !");
//         personnages.RemoveAt(defenderIndex);
//     }
// }

// // Déclarer le vainqueur final (si un seul personnage restant)
// if (personnages.Count == 1)
// {
//     Console.WriteLine($"Le vainqueur final est : {personnages[0].Classe} !");
// }

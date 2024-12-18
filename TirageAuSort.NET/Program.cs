using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tableau car je veux une taille fixe de personne
            string[] participants = new string[15]
            {
                "Jean",
                "François",
                "Hugo",
                "Lea",
                "Leo",
                "Marie",
                "Paul",
                "Sophie",
                "Luc",
                "Emma",
                "Pierre",
                "Julie",
                "Nicolas",
                "Alice",
                "Thomas"
            };

            // Je crée une liste parce que je dois ajouter et supprimer des élements
            List<string> participantsTirer = new List<string>();


            do
            {
                Console.WriteLine("--- Menu tirage au sort  ---\n");
                Console.WriteLine("1 --- Effectuer un tirage");
                Console.WriteLine($"2 --- Voir la liste des personnes déjà tirés ({participantsTirer.Count})");
                Console.WriteLine($"3 --- Voir la liste des personnes restantes ({participants.Length - participantsTirer.Count})"); // Personnes restante = la taille du tableau moins celle de la liste
                Console.WriteLine("0 -- Quitter");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Random random = new Random(); // Je déclare une var random
                        int i = random.Next(0, participants.Length); // je déclare une variable i qui est entre 0 et la taille de mon tableau
                        for (int j = 0; j < participants.Length; j++)  // Tant que "j" est inférieur a la taille de mon tableau alors je l'incrémente
                        {
                            Console.Write($"\r{participants[j]}     "); //j'itére mon tableau avec j 
                            Thread.Sleep(200); // j'ai un délai de 200ms a chaque affichage de l'itération 
                        }
                        if (!participantsTirer.Contains(participants[i])) // si ma liste ne CONTIENS pas l'index selectionné de mon tableau
                        {
                            participantsTirer.Add(participants[i]); // Alors j'ajoute l'index de mon tableau a ma liste
                        }
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine($"L'hereux(se) gagnant(e) est {participants[i]} ! \n");
                        Console.ResetColor();
                        break;
                    case 2:
                        Console.Clear();
                          Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Liste des personnes déjà tirée  :\n");
                        Console.ResetColor();
                        foreach (string pt in participantsTirer)
                        {
                            Console.WriteLine($"\t {pt}");
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Liste des personnes restantes :");
                        Console.ResetColor();
                        foreach (string p  in participants)
                        {
                            if(!participantsTirer.Contains(p))
                            {
                                Console.WriteLine($"\t {p}");
                            }
                        }
                        break;
                     default: // Tout ce qui n'éxiste pas en tant que case, valeur de défault
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vous n'étes pas autorisée a effectuer cette action.");
                        Console.ResetColor();
                        break; 
                        
                }

            }
            while (true);
        }
    }
}
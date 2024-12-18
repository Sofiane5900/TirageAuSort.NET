using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            List<string> participantsTirer = new List<string>();


            do
            {
                Console.WriteLine("--- Menu tirage au sort  ---\n");
                Console.WriteLine("1 --- Effectuer un tirage");
                Console.WriteLine($"2 --- Voir la liste des personnes déjà tirés ({participantsTirer.Count})");
                Console.WriteLine($"3 --- Voir la liste des personnes restantes ({participants.Length - participantsTirer.Count})");
                Console.WriteLine("0 -- Quitter");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Random random = new Random();
                        random.Next(participants.Length);
                        int i = random.Next(0, participants.Length);
                        for (int j = 0; j < participants.Length; j++)
                        {
                            Console.Write($"\r{participants[j]}     ");
                            Thread.Sleep(200);
                        }
                        if (!participantsTirer.Contains(participants[i]))
                        {
                            participantsTirer.Add(participants[i]);
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
                     default:
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
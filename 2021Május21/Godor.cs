using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _2021Május21
{
    class Godor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            string[] felszín = File.ReadAllLines("melyseg.txt");
            Console.WriteLine($"A fájl adatainak száma: {felszín.Length}");

            Console.WriteLine("2. feladat");
            Console.Write("Adjon meg egy távolságértéket! ");
            int megadottGodorIndex = int.Parse(Console.ReadLine());
            int valósGödörIndex = megadottGodorIndex - 1;
            Console.WriteLine($"Ezen a helyen a felszín {felszín[valósGödörIndex]} méter mélyen van.");

            Console.WriteLine("3. feladat");
            float érintetlenFelszinSzazalek = (float)Array.FindAll(felszín, x => x == "0").Length / felszín.Length * 100;
            Console.WriteLine("Az érintetlen terület aránya {0:n2}%.", érintetlenFelszinSzazalek);

            List<string> godrok = new List<string>();
            string godorMelysegek = string.Empty;
            foreach (string godor in felszín)
                if (godor == "0")
                {
                    if (godorMelysegek != string.Empty)
                    {
                        godrok.Add(godorMelysegek);
                        godorMelysegek = string.Empty;
                    }
                }
                else
                    godorMelysegek += $" {godor}";
            File.WriteAllLines("godrok.txt", godrok);

            Console.WriteLine("5. feladat");
            Console.WriteLine($"A gödrök száma: {godrok.Count}");

            Console.WriteLine("6. feladat");
            if (felszín[valósGödörIndex] == "0")
                Console.WriteLine("Az adott helyen nincs gödör.");
            else
            {
                List<int> godor = new List<int>();
                godor.Add(int.Parse(felszín[valósGödörIndex]));

                int godorElejeIndex = megadottGodorIndex;
                for (int i = valósGödörIndex - 1; i > 0; i--)
                    if (felszín[i] != "0")
                    {
                        godorElejeIndex = i;
                        godor.Insert(0, int.Parse(felszín[i]));
                    }
                    else
                        break;

                int godorVégeIndex = megadottGodorIndex;
                for (int i = valósGödörIndex + 1; i < felszín.Length - valósGödörIndex - 1; i++)
                    if (felszín[i] != "0")
                    {
                        godorVégeIndex = i;
                        godor.Add(int.Parse(felszín[i]));
                    }
                    else
                        break;
                
                bool mélyül = true;
                bool folyamatosanMélyül = true;
                for (int i = 1; i < godor.Count - 1; i++)
                {
                    if (godor[i - 1] >= godor[i])
                        mélyül = false;
                    if (!mélyül && godor[i-1] > godor[i])
                    {
                        folyamatosanMélyül = false;
                        break;
                    }
                }

                Console.WriteLine("a)");
                Console.WriteLine($"A gödör kezdete: {godorElejeIndex + 1}, a gödör vége: {godorVégeIndex + 1} méter");
                Console.WriteLine("b)");
                if (folyamatosanMélyül)
                    Console.WriteLine("Folyamatosan mélyül.");
                else
                    Console.WriteLine("Nem mélyül folyamatosan.");
                Console.WriteLine("c)");
                Console.WriteLine($"A legnagyobb mélysége {godor.Max()} méter.");
                Console.WriteLine("d)");
                Console.WriteLine($"A térfogata {godor.Sum(x => x) * 10} m^3.");
                Console.WriteLine("e)");
                Console.WriteLine($"A vízmennyiség {godor.Sum(x => x-1) * 10} m^3.");
            }

            Console.ReadLine();
        }
    }
}

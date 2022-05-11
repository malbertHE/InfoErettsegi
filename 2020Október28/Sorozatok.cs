using System;
using System.Collections.Generic;
using System.IO;

namespace _2020Október28
{
    class Sorozatok
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("lista.txt");

            Console.WriteLine("2. feladat");
            int ismertDátumúEpizódokSzáma = 0;
            for (int i = 0; i < adatok.Length; i += 5)
                if (adatok[i] != "NI")
                    ismertDátumúEpizódokSzáma++;
            Console.WriteLine($"A listában {ismertDátumúEpizódokSzáma} db vetítési dátummal rendelkező epizód van.");
            Console.WriteLine();

            Console.WriteLine("3. feladat");
            int megnézettekSzáma = 0;
            for (int i = 0; i < adatok.Length; i += 5)
                if (adatok[i + 4] != "0")
                    megnézettekSzáma++;
            Console.WriteLine("A listában lévő epizódok {0:n2}%-át látta.", (float)megnézettekSzáma / (adatok.Length / 5) * 100);
            Console.WriteLine();

            Console.WriteLine("4. feladat");
            int összIdő = 0;
            for (int i = 0; i < adatok.Length; i += 5)
                if (adatok[i + 4] != "0")
                    összIdő += int.Parse(adatok[i+3]);
            Console.WriteLine($"Sorozatnézéssel {összIdő / 60 / 24} napot {összIdő / 60 % 24} órát és {összIdő % 60} percet töltött.");
            Console.WriteLine();

            Console.WriteLine("5. feladat");
            Console.Write("Adjon meg egy dátumot! Dátum= ");
            string megadottDátum = Console.ReadLine();
            for (int i = 0; i < adatok.Length; i += 5)
                if (adatok[i] != "NI" && adatok[i + 4] == "0" && DateTime.Parse(megadottDátum) >= DateTime.Parse(adatok[i]))
                    Console.WriteLine($"{adatok[i+2]} {adatok[i+1]}");
            Console.WriteLine();

            Console.WriteLine("7. feladat");
            Console.Write("Adja meg a hét egy napját (például cs)! Nap= ");
            string megadottNap = Console.ReadLine();
            List<string> adottNaponVetítettFilmek = new List<string>();
            for (int i = 0; i < adatok.Length; i += 5)
                if (!adottNaponVetítettFilmek.Contains(adatok[i + 1]) && DateTime.TryParse(adatok[i], out DateTime vetítésDátuma) && 
                    hetnapja(vetítésDátuma.Year, vetítésDátuma.Month, vetítésDátuma.Day) == megadottNap) adottNaponVetítettFilmek.Add(adatok[i+1]);
            if (adottNaponVetítettFilmek.Count == 0)
                Console.WriteLine("Az adott napon nem kerül adásba sorozat.");
            else
                for (int i = 0; i < adottNaponVetítettFilmek.Count; i++)
                    Console.WriteLine(adottNaponVetítettFilmek[i]);

            List<int> sorozatokÖsszesítettVetítésiIdői = new List<int>();
            List<int> epizodokSzáma = new List<int>();
            List<string> sorozatNevek = new List<string>();
            sorozatNevek.Add(adatok[1]);
            epizodokSzáma.Add(1);
            sorozatokÖsszesítettVetítésiIdői.Add(int.Parse(adatok[3]));
            int utolsóElemIndexe;
            for (int i = 5; i < adatok.Length; i += 5)
            {
                utolsóElemIndexe = sorozatNevek.Count - 1;
                if (adatok[i + 1] == sorozatNevek[utolsóElemIndexe])
                {
                    sorozatokÖsszesítettVetítésiIdői[utolsóElemIndexe] += int.Parse(adatok[i + 3]);
                    epizodokSzáma[utolsóElemIndexe]++;
                }
                else
                {
                    sorozatNevek[utolsóElemIndexe] = $"{sorozatNevek[utolsóElemIndexe]} {sorozatokÖsszesítettVetítésiIdői[utolsóElemIndexe]} {epizodokSzáma[utolsóElemIndexe]}";
                    sorozatNevek.Add(adatok[i + 1]);
                    epizodokSzáma.Add(1);
                    sorozatokÖsszesítettVetítésiIdői.Add(int.Parse(adatok[i + 3]));
                }
            }
            utolsóElemIndexe = sorozatNevek.Count - 1;
            sorozatNevek[utolsóElemIndexe] = $"{sorozatNevek[utolsóElemIndexe]} {sorozatokÖsszesítettVetítésiIdői[utolsóElemIndexe]} {epizodokSzáma[utolsóElemIndexe]}";
            File.WriteAllLines("summa.txt", sorozatNevek);

            Console.ReadLine();
        }

        static string hetnapja(int ev, int ho, int nap)
        {
            string[] napok = new string[] { "v", "h", "k", "sze", "cs", "p", "szo" };
            int[] honapok = new int[] { 0, 3, 4, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
            if (ho < 3)
                ev = ev - 1;
            return napok[(ev + ev / 4 - ev / 100 + ev / 400 + honapok[ho - 1] + nap) % 7 ];
        }
    }
}

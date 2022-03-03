using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace _2021Október26
{
    class Sudoku
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");
            Console.Write("Adja meg a bemeneti fájl nevét: ");
            string fájlNeve = Console.ReadLine();
            Console.Write("Adja meg a sor számát: ");
            int megadottSorszám = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Adja meg az oszlop számát: ");
            int megadottOszlopszám = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine();

            string[] adatSorok = File.ReadAllLines(fájlNeve);
            int[][] mátrix = adatSorok.Take(9).Select(sor => sor.Split(' ').Select(érték => int.Parse(érték)).ToArray()).ToArray();

            Console.WriteLine("3. feladat");
            if (mátrix[megadottSorszám][megadottOszlopszám] == 0)
                Console.WriteLine("Az adtott helyet még nem töltötték ki.");
            else
                Console.WriteLine($"Az adott helyen szereplő szám: {mátrix[megadottSorszám][megadottOszlopszám]}");
            Console.WriteLine($"A hely a(z) {RésztáblázatSzáma(megadottSorszám, megadottOszlopszám)} résztáblázathoz tartozik.");
            Console.WriteLine();

            Console.WriteLine("4. feladat");
            float üresHelyekAránya = (float)(from sor in mátrix from mező in sor where mező == 0 select mező).Count() / (9 * 9) * 100;
            Console.WriteLine($"Üres helyek aránya: {üresHelyekAránya:n1}%");
            Console.WriteLine();

            Console.WriteLine("5. feladat");
            List<Lépés> lépések = adatSorok.Skip(9).Select(sor => sor.Split(' '))
                    .Select(mezők => new Lépés() { MegadottSzám = int.Parse(mezők[0]), SorSzáma = int.Parse(mezők[1])-1, OszlopSzáma = int.Parse(mezők[2])-1 }).ToList();
            lépések.ForEach(lépés => Console.Write(LépésInfó(lépés, mátrix)));

            Console.ReadLine();
        }

        static int RésztáblázatSzáma(int megadottSorszám, int megadottOszlopszám)
        {
            return 1 + (((megadottSorszám - 1) / 3) * 3) + ((megadottOszlopszám - 1) / 3);
        }

        static string LépésInfó(Lépés lépés, int[][] mátrix)
        {
            string lépésInfó = string.Empty;
            if (mátrix[lépés.SorSzáma][lépés.OszlopSzáma] != 0)
                lépésInfó += $"A helyet már kitöltötték.{Environment.NewLine}";
            else
            {
                if (Array.Exists(mátrix[lépés.SorSzáma], mező => mező == lépés.MegadottSzám))
                    lépésInfó += $"Az adott sorban már szerepel a szám.{Environment.NewLine}";
                if (mátrix.Select(sor => sor[lépés.OszlopSzáma]).ToList().Exists(mező => mező == lépés.MegadottSzám))
                    lépésInfó += $"Az adott oszlopban már szereple a szám.{Environment.NewLine}";
                int részTáblaElsőSora = lépés.SorSzáma / 3 * 3;
                int részTáblaElsőOszlopa = lépés.OszlopSzáma / 3 * 3;
                for (int i = részTáblaElsőSora; i < részTáblaElsőSora + 3; i++)
                    for (int j = részTáblaElsőOszlopa; j < részTáblaElsőOszlopa + 3; j++)
                        if (mátrix[i][j] == lépés.MegadottSzám)
                            lépésInfó += $"Az adott résztáblázatban már szerepel a szám.{Environment.NewLine}";
            }
            if (lépésInfó == string.Empty)
                lépésInfó = $"A lépés megtehető.{Environment.NewLine}";
            return lépés.ToString() + Environment.NewLine + lépésInfó;
        }
    }

    class Lépés
    {
        public int MegadottSzám;
        public int SorSzáma;
        public int OszlopSzáma;

        public override string ToString()
        {
            return $"A kiválasztott sor: {SorSzáma+1} oszlop: {OszlopSzáma+1} a szám: {MegadottSzám}";
        }

    }
}

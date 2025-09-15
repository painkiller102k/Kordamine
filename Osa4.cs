using System;
using System.IO;
using System.Collections.Generic;

namespace Kordamine
{
    internal class Osa4
    {
        public static void Kirjuta_failisse()
        {
            try
            {
                string path = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "kuud.txt");

                using (StreamWriter text = new StreamWriter(path, true))
                {
                    string lause = Console.ReadLine();
                    text.WriteLine(lause);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

        public static void Failide_lugemine(string failinimi)
        {
            try
            {
                string path = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    failinimi);

                using (StreamReader text = new StreamReader(path))
                {
                    string sisu = text.ReadToEnd();
                    Console.WriteLine(sisu);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        public static List<string> Ridade_lugemine()
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "kuud.txt");

                foreach (string rida in File.ReadAllLines(path))
                {
                    if (!string.IsNullOrWhiteSpace(rida))
                        kuude_list.Add(rida);
                }

                foreach (string kuu in kuude_list)
                    Console.WriteLine(kuu);

                Console.WriteLine("Sisesta kuu, mida otsid:");
                string otsitav = Console.ReadLine();
                if (kuude_list.Contains(otsitav))
                    Console.WriteLine("Kuu " + otsitav + " on olemas.");
                else
                    Console.WriteLine("Sellist kuud pole.");

                kuude_list.Remove("Juuni");
                if (kuude_list.Count > 0)
                    kuude_list[0] = "Veeel kuuu";

                Console.WriteLine("Uuendatud kuude list:");
                foreach (string kuu in kuude_list)
                    Console.WriteLine(kuu);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }

            return kuude_list;
        }

        public class Toode
        {
            public string Nimi;
            public double Kalorid100g;

            public Toode(string nimi, double kalorid100g)
            {
                Nimi = nimi;
                Kalorid100g = kalorid100g;
            }
        }

        public static List<Toode> LoeTootedFailist()
        {
            List<Toode> tooted = new List<Toode>();
            try
            {
                string path = Path.Combine(
                    Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,
                    "tooted.txt");

                foreach (string rida in File.ReadAllLines(path))
                {
                    string[] osad = rida.Split(',');
                    if (osad.Length == 2 && double.TryParse(osad[1].Trim().Replace(",", "."), out double kalorid))
                    {
                        tooted.Add(new Toode(osad[0].Trim(), kalorid));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
            }

            return tooted;
        }

        public class Inimene
        {
            public string Nimi;
            public int Vanus;
            public string Sugu;
            public double Pikkus;
            public double Kaal;
            public double Aktiivsustase;

            public Inimene(string nimi, int vanus, string sugu, double pikkus, double kaal, double aktiivsus)
            {
                Nimi = nimi;
                Vanus = vanus;
                Sugu = sugu;
                Pikkus = pikkus;
                Kaal = kaal;
                Aktiivsustase = aktiivsus;
            }

            public double KaloridPäevas()
            {
                double bmr;
                if (Sugu.ToUpper() == "M")
                    bmr = 88.36 + (13.4 * Kaal) + (4.8 * Pikkus) - (5.7 * Vanus);
                else
                    bmr = 447.6 + (9.2 * Kaal) + (3.1 * Pikkus) - (4.3 * Vanus);

                return bmr * Aktiivsustase;
            }
        }

        public static void OkrugidJaLinnad()
        {
            Dictionary<string, string> okrugid = new Dictionary<string, string>()
            {
                { "Harjumaa", "Tallinn" },
                { "Tartumaa", "Tartu" },
                { "Pärnumaa", "Pärnu" },
                { "Raplamaa", "Rapla" },
                { "Lääne-Virumaa", "Rakvere"},
                { "Järvemaa", "Paide"}
            };

            Console.WriteLine("Sisesta okrugi nimi:");
            string okrug = Console.ReadLine();

            if (okrugid.ContainsKey(okrug))
            {
                Console.WriteLine("Pealinn: " + okrugid[okrug]);
            }
            else
            {
                Console.WriteLine("Sellist okrugi pole. Lisa uus!");
                Console.WriteLine("Sisesta pealinna nimi:");
                string linn = Console.ReadLine();
                okrugid.Add(okrug, linn);
                Console.WriteLine("Lisatud!");
            }

            Console.WriteLine("Kõik okrugid ja pealinnad:");
            foreach (var paar in okrugid)
            {
                Console.WriteLine(paar.Key + " - " + paar.Value);
            }
        }
    }
}

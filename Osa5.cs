namespace Kordamine;

internal class Osa5
{
     public class Inimene // osa5 ulesanne #1
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

        public static void OkrugidJaLinnad() // #osa5 ulesanne #2
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
        
    public class õpilane // #osa5 ulesanne 3
    {
        public string Nimi { get; } //
        public List<int> Hinne { get; }

        public õpilane(string nimi, List<int> hinne)
        {
            Nimi = nimi;
            Hinne = hinne;
        }

        public double Keskmine()
        {
            return Hinne.Average();
        }
    }

    public class Ulesanne3
    {
        public static void Analuusiõpilane()
        {
            List<õpilane> õpilased = new List<õpilane>()
            {
                new õpilane("Martin", new List<int>{5, 4, 3, 5}),
                new õpilane("Illia", new List<int>{4, 4, 5, 5}),
                new õpilane("Mark", new List<int>{3, 2, 4, 4})
            };

            Console.WriteLine("Õpilaste keskmised hinded:");
            foreach (var u in õpilased)
            {
                Console.WriteLine($"{u.Nimi}: {u.Keskmine():F2}");
            }

            var best = õpilased.OrderByDescending(u => u.Keskmine()).First();
            Console.WriteLine($"Best õpilane: {best.Nimi}, keskmine hinne: {best.Keskmine():F2}");
        }
    }
    public class Film // #osa5 ulesanne 4
    {
        public string Nimi { get; }
        public int Aasta { get; }
        public string Zanr { get; }

        public Film(string nimi, int aasta, string zanr)
        {
            Nimi = nimi;
            Aasta = aasta;
            Zanr = zanr;
        }
    }

    public class Ulesanne4
    {
        public static void FilmiAnalüüs()
        {
            List<Film> filmid = new List<Film>()
            {
                new Film("Matrix", 1999, "SciFi"),
                new Film("The Astral", 1010, "Horror"),
                new Film("Interstellar", 2014, "SciFi"),
                new Film("Forrest Gump", 1994, "Drama"),
                new Film("Smile 2", 2024, "Horror")
            };
            Console.WriteLine("Sisesta žanr ( SciFi, Horror, Drama ): ");
            string zanr = Console.ReadLine();

            var samaZanriga = filmid.Where(f => f.Zanr.Equals(zanr, StringComparison.OrdinalIgnoreCase)).ToList(); //все фильмы с один. жанром

            if (samaZanriga.Count > 0)
            {
                Console.WriteLine($"Filmid žanrist {zanr}:");
                foreach (var film in samaZanriga)
                {
                    Console.WriteLine($"{film.Nimi} ({film.Aasta})");
                }
            }
            else
            {
                Console.WriteLine($"Žanris {zanr} filme ei leitud.");
            }
            var uusim = filmid.OrderByDescending(f => f.Aasta).First(); // по году
            Console.WriteLine($"Kõige uuem film: {uusim.Nimi} ({uusim.Aasta}");
            
            Console.WriteLine("Filmid žanrite järgi:");
            var grupp = filmid.GroupBy(f => f.Zanr); // groupby по фильм - жанр
            foreach (var g in grupp) 
            {
                Console.WriteLine($"Žanr: {g.Key}"); // название жанра
                foreach (var film in g)
                {
                    Console.WriteLine($"  {film.Nimi} ({film.Aasta})");
                }
            }
        }
    }
}

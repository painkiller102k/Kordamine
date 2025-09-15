namespace Kordamine;

internal class Osa5
{
    public class õpilane
    {
        public string Nimi { get; }
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
    public class Film
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

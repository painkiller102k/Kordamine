namespace Kordamine
{
    public class Isik
    {
        public string eesnimi;
        public string perenimi = "Tundmatu";
        public int synniaasta = 2000;

        public Isik()
        {
        }

        public Isik(string eesnimi, string perenimi)
        {
            this.eesnimi = eesnimi;
            this.perenimi = perenimi;
        }

        public void Prindi_andmed()
        {
            Console.WriteLine($"Isiku andmed: {eesnimi} {perenimi}, Sündinud: {synniaasta}");
        }
    }

    public class Osa3
    {
        internal class ArvuTootlus
        {
            public static int[] GenereeriRuudud(int min, int max)
            {
                Random rnd = new Random();
                int m = rnd.Next(min, max);
                int n = rnd.Next(min, max);
                Console.WriteLine(m);
                Console.WriteLine(n);
                Console.WriteLine(Math.Abs(m - n) + 1);

                int[] massive = new int[Math.Abs(m - n) + 1];
                int k = 0;

                if (m < n)
                {
                    for (int i = m; i <= n; i++)
                    {
                        massive[k] = i * i;
                        k++;
                    }
                }
                else
                {
                    for (int i = n; i <= m; i++)
                    {
                        massive[k] = i * i;
                        k++;
                    }
                }

                return massive;
            }
        }
    }

    public class Osa33
    {
        public static double[] Tekstist_arvud()
        {
            Console.WriteLine("Sisesta arvud koma või tühikuga eraldatult: ");
            string sisend = Console.ReadLine();
            char[] eraldajad = new char[] { ' ' };

            string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);

            double[] arvud = new double[osad.Length];
            for (int i = 0; i < osad.Length; i++)
            {
                arvud[i] = Convert.ToDouble(osad[i]);
            }

            return arvud;
        }

        public class Inimene
        {
            public string Nimi;
            public int Vanus;

            public Inimene(string nimi, int vanus)
            {
                Nimi = nimi;
                Vanus = vanus;
            }
        }

        public static class Statistika
        {
            public static void TeeStatistika(List<Inimene> inimesed)
            {
                int summa = inimesed.Sum(x => x.Vanus);
                double keskmine = inimesed.Average(x => x.Vanus);
                Inimene vanim = inimesed.OrderByDescending(x => x.Vanus).First();
                Inimene noorim = inimesed.OrderBy(x => x.Vanus).First();

                Console.WriteLine("Vanuste summa: " + summa);
                Console.WriteLine("Keskmine vanus: " + keskmine);
                Console.WriteLine("Vanim inimene: " + vanim.Nimi + ", " + vanim.Vanus + " aastat");
                Console.WriteLine("Noorim inimene: " + noorim.Nimi + ", " + noorim.Vanus + " aastat");
            }
        }

        public static string KuniMarksonani(string märksõna, string frass)
        {
            do
            {
                Console.WriteLine("Osta elevant ära!");
                frass = Console.ReadLine();
            } while (frass.ToLower() != märksõna.ToLower());

            return frass;
        }

        public static void Arvanumber()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 3);
            int attempt = 5;

            while (attempt > 0)
            {
                Console.WriteLine("Sisesta number : ");
                int number = int.Parse(Console.ReadLine());

                if (number == n)
                {
                    Console.WriteLine("See on õige number");
                    return;
                }
                else if (number < n)
                {
                    Console.WriteLine("See number väikse");
                }
                else
                {
                    Console.WriteLine("See number suurem");
                }

                attempt--;
            }

            Console.WriteLine("Proovid said otsa! Õige number oli: " + n);
        }

        public static int SuurimNeljarv(double[] arvud)
        {
            foreach (double num in arvud)
            {
                if (num < 0 || num > 9 || num != Math.Floor(num))
                {
                    Console.WriteLine("Viga!");
                    return -1;
                }
            }
            Array.Sort(arvud);
            Array.Reverse(arvud);
            int suurim = 0;
            foreach (double num in arvud)
            {
                suurim = suurim * 10 + (int)num;
            }

            return suurim;
        }
        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv)
        {
            int[,] tabel = new int[ridadeArv, veergudeArv];
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    tabel[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < ridadeArv; i++)
            {
                for (int j = 0; j < veergudeArv; j++)
                {
                    Console.Write(tabel[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            return tabel;
        }
    }
}
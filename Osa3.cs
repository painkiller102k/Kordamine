namespace Kordamine;

public class Isik
{
    public string eesnimi;
    public string perenimi="Tundmatu";
    public int synniaasta=2000;
    
    public Isik() { }

    public Isik(string eesnimi, string perenimi)
    {
        this.eesnimi = eesnimi;
        this.perenimi = perenimi;
    }

    public void Prindi_andmed()
    {
        Console.WriteLine($"Isiku andmed: {eesnimi} {perenimi}, Sündinud:  {synniaasta}");
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
            Console.WriteLine(Math.Abs(m - n)+1);
            int[] massive = new int[Math.Abs(m - n)+1];
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
                for (int i = m; i <= n; i++)
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
        char[] eraldajad = new char[] { ' ' }; //

        string[] osad = sisend.Split(eraldajad, StringSplitOptions.RemoveEmptyEntries);

        double[] arvud = new double[osad.Length];
        for (int i = 0; i < osad.Length; i++)
        {
            arvud[i] = Convert.ToDouble(osad[i]);
        }

        return arvud;
    }

    public static Tuple<double, double, double> AnaluusiArve(double[] arvud)
    {
        double summa = arvud.Sum();
        double keskmine = arvud.Average();
        double korrutis = 1;
        foreach (double arv in arvud)
        {
            korrutis *= arv;
        }
        return Tuple.Create(summa, keskmine, korrutis);
    }
}
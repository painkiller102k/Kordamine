using System.Text;

namespace Kordamine
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // #osa1
            //int[] massive = Osa3.ArvuTootlus.GenereeriRuudud(-10, 10);
            //Console.WriteLine("Genereeritud ruudud:");
            //foreach (int m in massive)
            //{
            // Console.WriteLine(m);
            //}

            // #osa2
            // double[] arvud = Osa33.Tekstist_arvud();
            // var tulemus = Osa33.AnaluusiArve(arvud);
            // Console.WriteLine($"Summa : {tulemus.Item1:F2}, Keskmine : {tulemus.Item2:F2}, Korrutis : {tulemus.Item3:F2}");

            // #3
            //List<Osa33.Inimene> inimesed = new List<Osa33.Inimene>();

            //Console.WriteLine("\nSisesta 5 inimese andmed:");

            //for (int i = 0; i < 5; i++)
            //{
            //Console.Write("Sisesta nimi: ");
            //string nimi = Console.ReadLine();

            //Console.Write("Sisesta vanus: ");
            //int vanus;
            // while (!int.TryParse(Console.ReadLine(), out vanus))
            //{
            //Console.Write("Palun sisesta korrektne täisarv: ");
            //}

            // inimesed.Add(new Osa33.Inimene(nimi, vanus));
            // }

            //Osa33.Statistika.TeeStatistika(inimesed);

            // #4
            //Console.WriteLine("Sisesta märksõna");
            //string marksõna = Console.ReadLine();
            //string frass = Console.ReadLine();
            //Osa33.KuniMarksonani(marksõna, frass);
            // #5
            //Osa33.Arvanumber();
            // #6
            //double[] arvud = new double[4];
            //for (int i = 0; i < 4; i++)
            //{
            // Console.WriteLine($"Sisesta {i + 1}. arv (0–9): ");
            //  arvud[i] = Convert.ToDouble(Console.ReadLine());
            // }

            //int tulemus = Osa33.SuurimNeljarv(arvud);
            //if (tulemus != -1)
            //{
            //Console.WriteLine("Suurim võimalik arv: " + tulemus);
            // }

            //#7
            //{
            //Console.Write("Sisesta ridade arv: ");
            //int read = int.Parse(Console.ReadLine());

            //Console.Write("Sisesta veergude arv: ");
            //int veerud = int.Parse(Console.ReadLine());

            // int[,] tabel = Osa33.GenereeriKorrutustabel(read, veerud);

            // Console.WriteLine();
            // Console.Write("Sisesta esimene arv: ");
            // int a = int.Parse(Console.ReadLine());

            //Console.Write("Sisesta teine arv: ");
            //int b = int.Parse(Console.ReadLine());

            //if (a >= 1 && a <= read && b >= 1 && b <= veerud)
            //{
            // Console.WriteLine($"{a} x {b} = {tabel[a - 1, b - 1]}");
            //}
            //else
            //{
            //Console.WriteLine("Arvud on väljaspool tabeli piire!");
            // }
            //}

            // Failitöötlus
            //Osa4.Kirjuta_failisse();
            //Console.WriteLine("Faili nimi: ");
            //string failinimi = Console.ReadLine();
            //Osa4.Failide_lugemine(failinimi);
            //Console.WriteLine("Ridade lugemine ja muudatused:");
            // Osa4.Ridade_lugemine();

            // #1 osa5
            //List<Osa4.Toode> tooted = Osa4.LoeTootedFailist();
            //Console.WriteLine("Sisesta oma nimi: ");
            //string nimi = Console.ReadLine();
            // Console.WriteLine("Sisesta vanus: ");
            // int vanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta sugu (M/N): ");
            // string sugu = Console.ReadLine();
            //Console.WriteLine("Sisesta pikkus cm: ");
            // double pikkus = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta kaal kg: ");
            //double kaal = double.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta aktiivsuse tase (1.2 - 1.9): ");
            //double aktiivsus = double.Parse(Console.ReadLine());

            // Osa4.Inimene kasutaja = new Osa4.Inimene(nimi, vanus, sugu, pikkus, kaal, aktiivsus);

            //double paevakogus = kasutaja.KaloridPäevas();
            //Console.WriteLine($"{nimi}, sinu päevane kalorivajadus on: {paevakogus:F0} kcal.");

            // Console.WriteLine($"Siin on, kui palju 100g-tooteid saad süüa, et katta päevane vajadus:");

            //foreach (Osa4.Toode t in tooted)
            //{
            //double grammid = paevakogus / t.Kalorid100g * 100;
            //Console.WriteLine($"{t.Nimi}: {grammid:F0} g");
            //}

            //Console.WriteLine("Failist kuud:");
            // List<string> kuud = Osa4.Ridade_lugemine();
            // #2 osa5
            Osa5.OkrugidJaLinnad();
            // #3 osa 5 
            Osa5.Ulesanne3.Analuusiõpilane();
            // #4 osa 5
            Osa5.Ulesanne4.FilmiAnalüüs();
        }
    }
}






// List<string> nimed=new List<string>();
            //for (int i = 0; i < 10; i++)
            // {
            //  Console.WriteLine($" {i + 1}. Nimi: ");
            //  nimed.Add(Console.ReadLine());
            //}


            // foreach (var item in nimed)
            //{
            // Console.WriteLine(item);
            //}




            //int[] arvud = new int[10];
            //int j = 0;
            //while (j < 10)
            //{
            // Console.WriteLine(j + 1);
            // arvud[j] = rnd.Next(1, 101);
            // j++;
            // }
            //foreach (var item in arvud)
            //{
            //   Console.WriteLine(item);
            //}

            // List<Isik> isikud =  new List<Isik>();
            // j = 0;
            // do
            // {
            // Console.WriteLine(j + 1);
            //  Isik isik = new Isik();
            //  Console.WriteLine("Eesnimi : ");
            // isik.eesnimi = Console.ReadLine();
            // isikud.Add(isik);
            //  j++;
            // } while (j<10);
            // Console.WriteLine($"Kokku on {isikud.Count()} isikud");
            //foreach (Isik isik in isikud)
            //{
            //    isik.Prindi_andmed();
            // }
            // Console.WriteLine($"Kolmandal kohal on {isikud[2].eesnimi} isik");











            // int kuu_number = rnd.Next(1, 12);
            // string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            //Console.WriteLine($"Nr: {kuu_number}-{nimetus}");
            // Console.WriteLine("Kas tahad dekodeerida arv-->nimutusse ?");
            //string vastus = Console.ReadLine();
            //if (vastus.ToLower() != "jah")
            //{
            // Console.WriteLine("Ei taha, siis ei taha");
            // }
            //else
            //  {
            // try
            // {
            //   Console.Write("Nr: ");
            //  kuu_number = int.Parse(Console.ReadLine());
            //  Console.Write(Osa1_funktsioonid.Hooaeg(kuu_number));
            //  }
            // catch (Exception e)
            //  {
            //     Console.WriteLine(e);
            // }

            // }

            //  Console.WriteLine("Mis on sinu nimi on: ?");
            // string vastus2 = Console.ReadLine();
            //  if (vastus2.ToLower() != "juku")
            //  {
            //     Console.WriteLine("Me ei lähe kinno!");
            //  }
            // else
            // {
            //    try
            //    {
            //    Console.Write("Kui vana sa oled : ?");
            //    int vastus3 = int.Parse(Console.ReadLine());
            //    Console.Write(Osa1_funktsioonid.Juku(vastus3));
            // }
            // catch (Exception e)
            // {
            //   Console.WriteLine(e);
            // }
            //  }

            //  Console.WriteLine("Mis on sinu nimi on: ?");
            // string nimi1 = Console.ReadLine();
            // Console.WriteLine("Aga mis on sinu nimi on: ?");
            //string nimi2 = Console.ReadLine();
            //if (nimi1.ToLower() == "martin" || nimi2.ToLower() == "illia")
            // {
            // Console.WriteLine("Te olete naabrid!");
            // }
            // else
            //{
            //Console.WriteLine("Ei olete naabrid!");
            //  }

            //Console.WriteLine("Sisesta esimese seina pikkus: ");
            //int seina1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sisesta teine seina pikkus: ");
            //int seina2 = int.Parse(Console.ReadLine());
            // int põrandapind = seina1 * seina2;
            //Console.WriteLine("Kas soovite teha remonti?");
            //string vastuss = Console.ReadLine();
            //if (vastuss.ToLower() != "jah")
            //{
            //   Console.WriteLine("Ei taha, siis ei taha");
            // }
            //else
            //{
            // Console.WriteLine("Kui palju maksab ruutmeetri: ?");
            //  int ruutmeentri = int.Parse(Console.ReadLine());
            // int hind = põrandapind / ruutmeentri;
            // Console.WriteLine($"Põranda vahetamise maksumus: {hind}");
            // }

            // Console.WriteLine("Kui palju sa selle kauba eest maksid?");
            // double kauba = double.Parse(Console.ReadLine());
            //double kaubahind = kauba / 0.70;
            //Console.WriteLine($"Algne hind: {kaubahind}");

            // Console.WriteLine("Mis on teie temperatuur?");
            // int temperatuur = int.Parse(Console.ReadLine());
            // if (temperatuur > 18)
            // {
            //Console.WriteLine("Temperatuur ületab!");
            //}
            //else
            //{
            //Console.WriteLine("Temperatuur sobib!");
            //}






//Console.WriteLine("Tere Tulemast!, Mis on sinu nimi?"); //сообщение в консоль через WriteLine
            //string tekst = Console.ReadLine(); // переменная tekst с типом данных string запоминается
            //Console.WriteLine($"{tekst}, Rõõm näha!"); // приветствие 
            //int a = 10; // переменная а с типом данных int равна 10
            //char taht = 'A'; // переменная taht с типом данных char равна A
            //Console.Write($"Esimene arv on {a}, sisesta b = ...."); // выводит в консоль то что первое чисто это 10 ( переменная а) и надо ввести чисто в переменной b
            //int b = int.Parse(Console.ReadLine()); // переменная b запоминается 
            // Console.WriteLine($"Vastus on = {a + b}"); // выводит в консоль ответ переменной a ( 10) + b
            //Console.WriteLine("Ujukomaarv"); // выводит в консоль Ujukommaarv
            //double d = double.Parse(Console.ReadLine()); // запоминает это число в типе данных double ( как float ) 
            //Console.WriteLine(d); // выводит переменную d
            // float f = float.Parse(Console.ReadLine()); // запоминает число в типе данных float в переменной f
            //Console.WriteLine(f); // выводит переменную f
            // bool g = false; // булево значение false / true

            //Random rnd = new Random(); // выполняется рандом
            // a = rnd.Next(-100, 200); // переменная a рандом от -100 до 200
            //Console.WriteLine(a); // выводит переменную a это рандомное число

            // float vastus = Osa1_funktsioonid.Kalkulaator(f, a); // переменная vastus в типе данных float выполняет функцию из другого файла со значениями f,a
            //Console.WriteLine($"Kalkulaatori tulemus: {vastus}"); // показывает в консоль ответ
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Random rnd = new Random(); // выполняется рандом
            int kuu_number = rnd.Next(1, 12);
            string nimetus = Osa1_funktsioonid.Kuu_nimetus(kuu_number);
            Console.WriteLine($"Nr: {kuu_number}-{nimetus}");
            Console.WriteLine("Kas tahad dekodeerida arv-->nimutusse ?");
            string vastus = Console.ReadLine();
            if (vastus.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                try
                {
                    Console.Write("Nr: ");
                    kuu_number = int.Parse(Console.ReadLine());
                    Console.Write(Osa1_funktsioonid.Hooaeg(kuu_number));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }

            Console.WriteLine("Mis on sinu nimi on: ?");
            string vastus2 = Console.ReadLine();
            if (vastus2.ToLower() != "juku")
            {
                Console.WriteLine("Me ei lähe kinno!");
            }
            else
            {
                try
                {
                    Console.Write("Kui vana sa oled : ?");
                    int vastus3 = int.Parse(Console.ReadLine());
                    Console.Write(Osa1_funktsioonid.Juku(vastus3));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            Console.WriteLine("Mis on sinu nimi on: ?");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Aga mis on sinu nimi on: ?");
            string nimi2 = Console.ReadLine();
            if (nimi1.ToLower() == "martin" || nimi2.ToLower() == "illia")
            {
                Console.WriteLine("Te olete naabrid!");
            }
            else
            {
                Console.WriteLine("Ei olete naabrid!");
            }

            Console.WriteLine("Sisesta esimese seina pikkus: ");
            int seina1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta teine seina pikkus: ");
            int seina2 = int.Parse(Console.ReadLine());
            int põrandapind = seina1 * seina2;
            Console.WriteLine("Kas soovite teha remonti?");
            string vastuss = Console.ReadLine();
            if (vastuss.ToLower() != "jah")
            {
                Console.WriteLine("Ei taha, siis ei taha");
            }
            else
            {
                Console.WriteLine("Kui palju maksab ruutmeetri: ?");
                int ruutmeentri = int.Parse(Console.ReadLine());
                int hind = põrandapind / ruutmeentri;
                Console.WriteLine($"Põranda vahetamise maksumus: {hind}");
            }

            Console.WriteLine("Kui palju sa selle kauba eest maksid?");
            double kauba = double.Parse(Console.ReadLine());
            double kaubahind = kauba / 0.70;
            Console.WriteLine($"Algne hind: {kaubahind}");

            Console.WriteLine("Mis on teie temperatuur?");
            int temperatuur = int.Parse(Console.ReadLine());
            if (temperatuur > 18)
            {
                Console.WriteLine("Temperatuur ületab!");
            }
            else
            {
                Console.WriteLine("Temperatuur sobib!");
            }






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
        }
    }
}
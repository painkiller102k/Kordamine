using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    internal class Osa1_funktsioonid
    {
        public static float Kalkulaator(float arv1, float arv2)
        {
            float k = arv1 * arv2;
            return k;
        }

        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruad"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "November"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "Viga";
                    break;
            }

            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) // && and , || or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12)
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "Viga";
            }

            return hoo;
        }

        public static string Juku(int juku_vana)
        {
            string ticket = "";
            if (juku_vana < 0 || juku_vana > 100)
            {
                return "Viga!";
            }
            else if (juku_vana < 6)
            {
                return "Tasuta!";
            }
            else if (juku_vana >= 6 && juku_vana <= 14)
            {
                return "Lapse pilet!";
            }
            else if (juku_vana >= 15 && juku_vana <= 65)
            {
                return "Täispilet";
            }
            else // juku_vana > 65
            {
                return "Sooduspilet!";
            }

            return ticket;
        }

        //public static string Pikkus(int pikkus_nr, string sugu)

    }
}
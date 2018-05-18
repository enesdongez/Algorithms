using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleShort_Algoritması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kaç elemanlı:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[a];
            for (int y = 0; y < a; y++)
            {
                Console.Write(y + ". elemanı gir:");
                dizi[y] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = 1; j < dizi.Length - i; j++)
                {
                    if (dizi[j] < dizi[j - 1])
                    {
                        int gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
            }
            for (int k = 0; k < dizi.Length; k++)
                Console.Write(dizi[k] + " ");

            Console.ReadKey();

        }
    }
}

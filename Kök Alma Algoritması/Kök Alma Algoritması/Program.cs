using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kök_Alma_Algoritması
{
    class Program
    {
        static double kok_al(double kok)
        {
            double x = 1;

            do
            {
                x = (x + kok / x) / 2;



            }
            while (x * x - kok > 0.00001);

            return x;

        }
        static void Main(string[] args)
        {
            Console.Write("sayıyı gir:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(a + " sayısının kökü=" + kok_al(a));
            Console.ReadKey();
        }
    }
}

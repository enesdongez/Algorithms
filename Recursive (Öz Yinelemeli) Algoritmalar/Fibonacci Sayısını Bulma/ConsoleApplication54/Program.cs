using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication54
{
    class Program
    {
        static int gg(int a)
        {
            int k = 1;
            int c = 1;
            int t = 1;
            for (int i = 3; i <= a; i++)
            {
                t = k + c;
                c = k;
                k = t;
                
            }
            return t;
        }
        public static int ff(int sayi)
        {
            if (sayi == 1 || sayi == 0)
                return 1;
            return ff(sayi - 1) + ff(sayi - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("sayıyı gir=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("normal="+ gg(a));
            Console.Write("recursive="+ff(a-1));
            Console.ReadKey();
        }
    }
}

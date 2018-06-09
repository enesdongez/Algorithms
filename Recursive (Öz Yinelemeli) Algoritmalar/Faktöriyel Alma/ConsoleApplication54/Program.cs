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
            if (a == 1)
                return 1;
            else
            {
                return a * gg(a - 1);
            }
        }
        static int ff(int a)
        {
            int t = 1;
            for (int i = 1; i <= a; i++)
            {
                t = t * i;
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.Write("sayıyı gir:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("normal=" + ff(a));
            Console.Write("recursive=" + gg(a));
            Console.ReadKey();
        }
    }
}

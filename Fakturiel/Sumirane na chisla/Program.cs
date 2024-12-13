using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumirane_na_chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int s,k,i,l;
            l = n / 1000;
            s = n % 1000 / 100;
            k= n % 100 / 10;
            i = n % 10;
            Console.WriteLine("хиляди " + l);
            Console.WriteLine("стотици " + s);
            Console.WriteLine("десетици " + k);
            Console.WriteLine("единици " + i);
        }
    }
}

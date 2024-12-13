using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakturiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int e = 1;
            int P = 1;
            while (e <= n)
            {
                P = e * P;
                e++;
            }
            Console.WriteLine(P);
        }
    }
}

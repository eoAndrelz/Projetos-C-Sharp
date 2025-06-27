using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class SomaNumeroPares
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Soma dos numeros pares entre 1 e 500");
            int n = 1, totalSoma = 0;
            do
            {
                n++;

                if (n % 2 == 0)
                {
                    totalSoma += n;
                }
            } while (n < 501);
            Console.WriteLine($"{totalSoma}");
        }
    }
}

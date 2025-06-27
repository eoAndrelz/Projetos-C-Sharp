using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class QuadradoDosNumerosInteiros
    {
        public static void Main(string[] args)
        {
            int i = 15;
            Console.WriteLine("Apresentar quadrado dos numeors inteiros de 15 a 200");
            do
            {
                Console.WriteLine($"{i}² = {Math.Pow(i, 2)}");
                i++;

            } while (i < 201);
        }
    }
}

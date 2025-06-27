using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ExemploVetor2D
    {
        public static void Main(string[] args)
        {
            int[] valores = { 10, 20, 30, 5, 10 };
            int totalSoma = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
                totalSoma += valores[i];
            }
            Console.WriteLine($"O resultado das somas dos valores é {totalSoma}");
        }
    }
}

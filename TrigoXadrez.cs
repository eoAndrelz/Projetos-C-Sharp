using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class TrigoXadrez
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatoria dos numeros de graos de trigo");
            ulong graosnoQuadro = 1;
            ulong totalGraos = 1;
            int quadro = 1;

            Console.WriteLine($"Quadro {quadro}: {graosnoQuadro} grao com o Total de {totalGraos}");

            do
            {
                quadro++;
                graosnoQuadro *= 2;
                totalGraos += graosnoQuadro;
                Console.WriteLine($"Quadro {quadro}: {graosnoQuadro} grãos | Total: {totalGraos}");

            } while (quadro < 5);
            Console.WriteLine($"\nTotal final de grãos no tabuleiro: {totalGraos}");
        }
    }
}

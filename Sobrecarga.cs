using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Sobrecarga
    {
        static int MetodoSomaComNumerosInteiros(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static float MetodoSomaComNumerosFlutuantes(float numero1, float numero2)
        {
            return numero1 + numero2;
        }

        public static void Main(string[] args)
        {
            int somaInt = MetodoSomaComNumerosInteiros(8, 5);
            float somaFloat = MetodoSomaComNumerosFlutuantes(6.5F, 9.8F);
            Console.WriteLine("Int: " + somaInt);
            Console.WriteLine("Double: " + somaFloat);


        }

    }
}

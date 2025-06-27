using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Sobrecarga02
    {
        static int MetodoSoma(int x, int y)
        {
            return x + y;
        }
        static double MetodoSoma(double x, double y)
        {
            return (x + y);
        }

        public static void Main(string[] args)
        {
            double[] numero = new double[2];
            Console.WriteLine($"Digite um Numero: ");
            numero[0]= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Digite outro numero: ");
            numero[1]= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numero[0]} + {numero[1]} = {MetodoSoma(numero[0], numero[1])}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class DiasSemana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor de 1 a 7 para descobrir qual dia da semana é: ");
            int diasSemana = Convert.ToInt32(Console.ReadLine());

            switch (diasSemana) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia invalido");
                    break ;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class MesesAno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 12 para representar um Mês do Ano");
            int Mes = Convert.ToInt32(Console.ReadLine());

            switch (Mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Maio");
                    break;
                case 6:
                    Console.WriteLine("Junho");
                    break;
                case 7:
                    Console.WriteLine("Julho");
                    break;
                    case 8:
                    Console.WriteLine("Agosto");
                    break;
                    case 9:
                    Console.WriteLine("Setembro");
                    break;
                    case 10:
                    Console.WriteLine("Outubro");
                    break;
                    case 11:
                    Console.WriteLine("Novembro");
                    break;
                    case 12:
                    Console.WriteLine("Dezembro");
                    break;
                    default:
                    Console.WriteLine("Numero invalido");
                    break; 
            }
        
        }
    }
}

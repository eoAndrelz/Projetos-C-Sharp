using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class VotoObrigatorio
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplos if, Else, ElseIf");
            int idade;
            Console.WriteLine("Digite a sua idade, para ver se esta apto a votar ou não");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 16)
            {
                Console.WriteLine("Não tem idade suficiente para Votar!");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Você pode votar, mas não é obrigatorio!");
            }
            else
            {
                Console.WriteLine("Você deve votar!");
            }
        }
    }
}

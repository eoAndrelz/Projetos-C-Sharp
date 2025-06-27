using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Objetos
    {
        string nome = "Miguel";
        string nacionalidade = "Brasileira";
        int idade = 27;

        public static void Main(string[] args)
        {
            Objetos professor = new Objetos();
            Objetos professor2 = new Objetos();

            Console.WriteLine($"O nome do Professor é: " + professor.nome);
            Console.WriteLine($"A nacionalidade do é: " + professor2.nacionalidade);



        }
    }
}

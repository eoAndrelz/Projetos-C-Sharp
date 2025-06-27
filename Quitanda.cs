using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Quitanda
    {
        public static void Main(string[]args) { 
        Fruta frutas = new Fruta();
            Console.WriteLine($"Fruta: {frutas.nome}\nPreço: R${frutas.preco}");
        }
    }
}

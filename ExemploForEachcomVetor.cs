using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ExemploForEachcomVetor
    {
        public static void Main(string[] args)
        {
            string[] aluno = { "André", "Guilherme", "Ana Julia", "Jonas", "Ingrid", "Gabriel" };
            Array.Sort(aluno);
            foreach (string s in aluno) {
                Console.WriteLine(s);
            }
        }
    }
}

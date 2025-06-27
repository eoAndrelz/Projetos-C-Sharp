using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ExemploWhile
    {
        public static void Main(string[] args)
        {
            int i = 10;
            do
            {
                i++;
                Console.WriteLine(i);
                
            }
            while (i < 5);
        }
    }
}
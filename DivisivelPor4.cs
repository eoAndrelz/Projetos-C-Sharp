using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class DivisivelPor4
    {
        public static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("");
            do
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i < 201);
        }
    }
}


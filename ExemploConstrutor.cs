using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ExemploConstrutor
    {
        
            public string modelo;
            public string cor;
            public int anos;

            public ExemploConstrutor(string modeloNome, string modeloCor, int modeloAno)
            {
            modelo = modeloNome;
            cor = modeloCor;
            anos = modeloAno;
            }

            static void Main(string[] args)
            {
            ExemploConstrutor Ford = new ExemploConstrutor("Scort", "Azul", 1983);
                Console.WriteLine(Ford.cor + " " + Ford.anos + " " + Ford.modelo);
            }
        }

    }


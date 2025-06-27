using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    using System;

    class Xadrez
    {
       public static  void Main(string[]args)
        {
           
            char[,] tabuleiro = new char[3, 3]
            {
            { 'X', 'O', 'X' },
            { 'O', 'X', 'O' },
            { 'O', 'X', 'O' }
            };

            // Exibir o tabuleiro
            Console.WriteLine("Tabuleiro:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {tabuleiro[i, j]} ");
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("-----------");
            }
            Console.WriteLine();

            
            char vencedor = VerificarVencedor(tabuleiro);

            
            if (vencedor == 'X' || vencedor == 'O')
            {
                Console.WriteLine($"O jogador '{vencedor}' venceu!");
            }
            else if (TabuleiroCompleto(tabuleiro))
            {
                Console.WriteLine("Deu velha!");
            }
            else
            {
                Console.WriteLine("O jogo ainda não terminou.");
            }
        }

        static char VerificarVencedor(char[,] tabuleiro)
        {
            // Verificar linhas
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] != ' ' && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                {
                    return tabuleiro[i, 0];
                }
            }

            // Verificar colunas
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[0, j] != ' ' && tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j])
                {
                    return tabuleiro[0, j];
                }
            }

            // Verificar diagonal principal
            if (tabuleiro[0, 0] != ' ' && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            {
                return tabuleiro[0, 0];
            }

            // Verificar diagonal secundária
            if (tabuleiro[0, 2] != ' ' && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            {
                return tabuleiro[0, 2];
            }

            // Se não houver vencedor
            return ' ';
        }

        static bool TabuleiroCompleto(char[,] tabuleiro)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
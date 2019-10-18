using System;

namespace _1650
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             Nível 3 

           * Você está visitando o Centro Pompidou que contém muitas pinturas modernas. Em particular você 
           * nota que uma pintura consiste somente em quadrados pretos e brancos, arranjados em linhas e colunas 
           * como em um tabuleiro de xadrez(sem que quadrados adjacentes tenham a mesma cor).

           Já que você está entediado, você se pergunta quantos tabuleiros de xadrez 8 x 8 formam a pintura. 
           O canto inferior direito do tabuleiro de xadrez tem que ser branco.
           **/


            Console.Write("Digite o número de linhas: ");
            double linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas: ");
            double colunas = int.Parse(Console.ReadLine());



            if (linhas < 8 || colunas < 8)
            {
                Console.WriteLine("Impóssivel montar tabuleiro. Linhas ou colunas insuficientes. ");
            }
            else
            {
                Console.Write("Qual a cor do canto inferior direito? (0 - branco | 1 - preto): ");
                int corCanto = int.Parse(Console.ReadLine());

                if (linhas == 8 && corCanto == 1)
                {
                    Console.WriteLine("Não foi possível formar nenhum tabuleiro");
                }
                else
                {
                    double diferencaLinhas = linhas % 8;
                    double diferencaColunas = colunas % 8;
                    int quantidadeLinhasTabuleiro = 8;


                    if (linhas > quantidadeLinhasTabuleiro)
                    {
                        if (diferencaLinhas != 0)
                        {
                            linhas -= diferencaLinhas;
                        }

                        if (diferencaColunas != 0)
                        {
                            colunas -= diferencaColunas;
                        }
                    }


                    double tabuleiro = (linhas * colunas) / 64;
                    if (tabuleiro >= 1)
                    {
                        int tabuleiroInt = (int)tabuleiro;
                        Console.WriteLine($"Conseguimos formar {tabuleiroInt} tabuleiros.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível formar nenhum tabuleiro");
                    }

                }
            }
        }
    }
}

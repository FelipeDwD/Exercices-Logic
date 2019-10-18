using System;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * Nível 5
             * Escreva um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, 
             * passando para a próxima linha a cada X números.
             **/



            Console.Write("Quantos números você quer por linha? ");
            int quebraLinha = int.Parse(Console.ReadLine());

            Console.Write("Qual o limite de número a imprimir? ");
            int limite = int.Parse(Console.ReadLine());

            string saida = "";


            for (int i = 1; i <= limite; i++)
            {
                for (int j = 0; j < quebraLinha; j++)
                {
                    saida += $"{i} ";
                    i++;
                }
                i--;
                saida += "\n";
            }


            Console.WriteLine(saida);
        }
    }
}

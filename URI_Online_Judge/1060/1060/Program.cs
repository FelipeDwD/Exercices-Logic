using System;
using System.Globalization;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
                Nível 1 

             * Faça um programa que leia 6 valores. Estes valores serão somente negativos ou positivos. 
             * A seguir, mostre a quantidade de valores positivos digitados.

            Entrada
            Seis valores, negativos e/ou positivos.

            Saída
            Imprima uma mensagem dizendo quantos valores positivos foram lidos.
            ***/



            double[] valores = new double[6];

            int positivos = 0;

            Console.WriteLine("Digite 6 valores, positivos e negativos: ");
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (valores[i] >= 0)
                {
                    positivos++;
                }
            }
            Console.WriteLine($"{positivos} valores positivos");
        }
    }
}

using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            /***              
             Nível 1

             * Faça um programa que leia um vetor N[20]. Troque a seguir, o primeiro elemento com o último, o segundo 
             * elemento com o penúltimo, etc., até trocar o 10º com o 11º. Mostre o vetor modificado.

                Entrada
                A entrada contém 20 valores inteiros, positivos ou negativos.
             **/


            int[] n = new int[20];
            int ultimo_elemento = (n.Length - 1);
            int aux = 0;

            string saida = "";


            //Recebendo valores e armazenando no vetor:
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }

            //Trocando os indíces de cada elemento:
            for (int i = 0; i < (n.Length / 2); i++)
            {
                aux = n[i];
                n[i] = n[ultimo_elemento];
                n[ultimo_elemento] = aux;
                ultimo_elemento--;
                
            }

            //Alimentando a string de saída para exibir no final:
            for (int i = 0; i < n.Length; i++)
            {
                saida += $"[{i}] = {n[i]}\n";
            }

            Console.WriteLine(saida);
            






        }
    }
}

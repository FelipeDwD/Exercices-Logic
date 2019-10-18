using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos vai ser alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());



            while (quantidadeQuartos > 10)
            {
                Console.Clear();
                Console.Write($"Não é possível alugar {quantidadeQuartos} quartos, só temos 10 disponíveis!" +
                    $"\nTente novamente: ");
                quantidadeQuartos = int.Parse(Console.ReadLine());
            }

            Quarto[] quartos = new Quarto[10];

            string report = "";

            Console.Clear();

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.Write($"Registro aluguel: {i + 1}\n");


                Console.Write("Qual o número do quarto? ");
                int numeroQuarto = int.Parse(Console.ReadLine());


                while (quartos[numeroQuarto] != null)
                {
                    Console.Clear();
                    Console.WriteLine($"Quarto já ocupado por: {quartos[numeroQuarto].Hospede.Nome}");
                    Console.Write("Tente outro quarto: ");
                    numeroQuarto = int.Parse(Console.ReadLine());
                    while (numeroQuarto < 0 || numeroQuarto > 10)
                    {
                        Console.Write($"{numeroQuarto} inválido, quartos somente de 0 a 9!\n Tente novamente: ");
                        numeroQuarto = int.Parse(Console.ReadLine());
                    }
                }
               

                Estudante estudante = new Estudante();

                quartos[numeroQuarto] = new Quarto();
                quartos[numeroQuarto].Numero = numeroQuarto;

                Console.Write($"Qual nome do estudante do quarto {numeroQuarto}? ");
                estudante.Nome = Console.ReadLine();


                Console.Write($"Digite o e-mail do estudante para o quarto {numeroQuarto}: ");
                estudante.Email = Console.ReadLine();

                quartos[numeroQuarto].Hospede = estudante;


                Console.Clear();
            }

            foreach (Quarto quartosOcupados in quartos)
            {
                if (quartosOcupados != null)
                {
                    report += quartosOcupados;
                }
            }
            Console.WriteLine(report);
        }
    }

}

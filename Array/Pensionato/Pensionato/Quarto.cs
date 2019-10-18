using System;
using System.Collections.Generic;
using System.Text;

namespace Pensionato
{
    class Quarto
    {
        public int Numero { get; set; }

        public Estudante Hospede { get; set; }

        public override string ToString()
        {
            return $"Número: {Numero}" +
                $"\nHóspede: {Hospede.Nome}" +
                $"\nE-mail: {Hospede.Email}\n\n";
        }
    }
}

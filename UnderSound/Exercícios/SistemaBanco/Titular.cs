using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios.SistemaBanco
{
    public class Titular
    {
        public Titular(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }
        public Titular() { }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}

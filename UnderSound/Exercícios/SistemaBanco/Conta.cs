using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios.SistemaBanco
{
    public class Conta
    {
		public Conta(int id, Titular titular, string senha, float saldo, int numero, float limite, string agencia)
		{
			Id = id;
			Titular = titular;
			Senha = senha;
			Saldo = saldo;
			Numero = numero;
			Limite = limite;
			Agencia = agencia;
		}

		public int Id { get; set; }
        public Titular Titular { get; set; }
        public string Senha { get; set; }
        public float Saldo { get; set; }
        public int Numero { get; set; }
        public float Limite { get; set; }
        public string Agencia { get; set; }
		public string Informacoes => $"Conta nº {this.Numero}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

		public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular.Nome}");
            Console.WriteLine($"Número da Conta: {Numero}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        /*Conta conta = new Conta();
		conta.titular = "Raissa Pereira Bloemer";
		conta.saldo = 49000.93f;
		conta.senha = "1234";
		conta.id = 1;
		conta.ExibirInformacoes();*/
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios
{
    public class Conta
    {
        public int id;
        public string titular, senha;
        public float saldo;

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: {saldo}");
        }

        /*Conta conta = new Conta();
		conta.titular = "Raissa Pereira Bloemer";
		conta.saldo = 49000.93f;
		conta.senha = "1234";
		conta.id = 1;
		conta.ExibirInformacoes();*/
    }


}

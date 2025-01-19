using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios.SistemaEstoque
{
    public class Produto
    {
        /*Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos
		 * e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.*/

        public string nome;
        public string marca;
        private float preco;
        public float Preco
        {
            get => preco;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor inserido deve ser positivo");
                }
                else
                {
                    preco = value;
                }
            }
        }
        private int quantidade;
        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Valor inserido deve ser positivo");
                }
                else
                {
                    quantidade = value;
                }
            }
        }
        public string InformacoesProduto
        {
            get
            {
                return $"Nome: {nome};\nPreço: {Preco}\nMarca: {marca}\nQuantidade: {quantidade}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios
{
	public class Produto
	{
		/*Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos
		 * e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.*/

		public string nome;
		public string marca;
		public float preco
		{
			get {  return preco; }

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
		public int estoque
		{
			get { return estoque; }
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("Valor inserido deve ser positivo");
				}
				else
				{
					estoque = value;
				}
			}
		}
		public string InformacoesProduto
		{
			get
			{
				return $"Nome: {nome};\nMarca: {preco}\nMarca: {marca}";
			}
		}
	}
}

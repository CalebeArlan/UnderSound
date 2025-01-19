using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios.SistemaEstoque
{
	public class Estoque
	{
		public static List<Produto> produtos = new List<Produto>();
		public static void AdicionarProdutos()
		{
			Produto produto = new Produto();
			//Nesse caso, sempre está criando instância nova de produto, quando, deveria verificar se o produto já existe.
			Console.Write("Digite o nome do produto: ");
			produto.nome = Console.ReadLine();
			Console.Write("Digite a marca do produto: ");
			produto.marca = Console.ReadLine();
			Console.Write("Digite a quantidade unitária do produto: ");
			produto.Preco = float.Parse(Console.ReadLine()!);
			Console.Write("Digite a quantidade de produtos a ser adicionada: ");
			produto.Quantidade = int.Parse(Console.ReadLine()!);
			produtos.Add(produto);
			Console.WriteLine("Produto adicionado com sucesso!");
			Menu();
		}
		public static void ExibirProdutosDoEstoque()
		{
            Console.WriteLine("*********************************************");
            foreach (Produto produto in produtos)
			{
				Console.WriteLine(produto.InformacoesProduto);
			}
			Console.WriteLine("*********************************************");
			Menu();
		}

		public static void Menu()
		{
			Console.WriteLine("Escolha uma opção a seguir:\n\n1 - Cadastrar Produto;\n2 - Exibir Todos os Produtos;");
			string escolha = Console.ReadLine()!;
			switch (escolha)
			{
				case "1":
					AdicionarProdutos();
					break;
				case "2":
					ExibirProdutosDoEstoque();
					break;
				default:
					Console.WriteLine("Opção Inválida!");
					Menu();
					break;
			}
		}

	}
}

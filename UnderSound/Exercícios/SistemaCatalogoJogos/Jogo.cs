using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderSound.Exercícios.SistemaCatalogoJogos
{
	public class Jogo
	{
		private static List<Jogo> jogos = new List<Jogo>();

		public Jogo(string nome, string genero, float preco)
		{
			Nome = nome;
			Genero = genero;
			Preco = preco;
		}

		public string Nome { get; set; }
		public string Genero {  get; set; }
		public float Preco { get; set; }

		public static void AdicionarJogo(Jogo jogo)
		{
			jogos.Add(jogo);
		}

		public void ExibirInformacoes()
		{
			Console.WriteLine($"Nome: {Nome};\nGênero: {Genero};\nPreço: {Preco};");
		}
	}
}

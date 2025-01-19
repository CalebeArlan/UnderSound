using UnderSound;

class Musica
{
	public string Nome { get; set; }
	public string Artista { get; set; }
	public int Duracao { get; set; }
	public bool Disponivel{ get;set; }
	public Genero Genero { get; set; }

	public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

	public void ExibirFichaTecnica()
	{
		Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
		Console.WriteLine($"Duração: {Duracao}");
		Console.WriteLine($"Gênero: {Genero.NomeGenero}");

		if (Disponivel)
		{
			Console.WriteLine("Disponível no plano.");
		}
		else
		{
			Console.WriteLine("Adquira o plano Plus+");
		}
    }

	public void ExibirNomeArtista()
	{
		Console.WriteLine($"Nome: {Nome}");
		Console.WriteLine($"Artista: {Artista}");
	}
}
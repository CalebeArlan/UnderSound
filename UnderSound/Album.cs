﻿public class Album
{
    private List<Musica> musicas = new List<Musica>();

	public Album(string nome)
	{
		Nome = nome;
	}

	public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Músicas do album {Nome}");
        foreach (var musica in musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos");
    }
}
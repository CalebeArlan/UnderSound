class Album
{
    private List<Musica> musicas = new List<Musica>();
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
        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal}");
    }
}
using UnderSound;

Musica musica1 = new Musica();
musica1.Nome = "For Those Who Wait";
musica1.Artista = "Fireflight";
musica1.Disponivel = true;


Musica musica2 = new Musica();
musica2.Nome] = "Debaixo da Terra";
musica2.Artista = "Os Under-Undergrounds";
musica2.Duracao = 290;
musica2.Disponivel = false;

Console.WriteLine(musica1.DescricaoResumida);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();





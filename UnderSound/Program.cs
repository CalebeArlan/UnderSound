using UnderSound;

Album albumDoSkillet = new Album();
albumDoSkillet.Nome = "Rise";

Musica musica1 = new Musica();
musica1.Nome = "Rise";
musica1.Duracao = 260;

Musica musica2 = new Musica();
musica2.Nome = "Sick of It";
musica2.Duracao = 190;

albumDoSkillet.AdicionarMusica(musica1);
albumDoSkillet.AdicionarMusica(musica2);

albumDoSkillet.ExibirMusicasDoAlbum();




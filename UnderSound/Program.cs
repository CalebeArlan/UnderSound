﻿using UnderSound;
using UnderSound.Exercícios;
using UnderSound.Exercícios.SistemaBanco;
using UnderSound.Exercícios.SistemaEstoque;

Album albumDoSkillet = new Album();
albumDoSkillet.Nome = "Rise";

Genero generoRock = new Genero();
generoRock.NomeGenero = "Rock";

Musica musica1 = new Musica();
musica1.Nome = "Rise";
musica1.Duracao = 260;
musica1.Genero = generoRock;

Musica musica2 = new Musica();
musica2.Nome = "Sick of It";
musica2.Duracao = 190;
musica2.Genero = generoRock;

albumDoSkillet.AdicionarMusica(musica1);
albumDoSkillet.AdicionarMusica(musica2);

//albumDoSkillet.ExibirMusicasDoAlbum();
musica1.ExibirFichaTecnica();

/*Instanciando Conta
Conta conta = new Conta();

conta.Titular = new Titular("Ruan Marcelino", "493.323.234-45");
conta.Saldo = 49000.93f;
conta.Senha = "1234";
conta.Numero = 117077;
conta.Agencia = "23";
conta.Limite = 4909f;
conta.Id = 1;
conta.ExibirInformacoes();
*/



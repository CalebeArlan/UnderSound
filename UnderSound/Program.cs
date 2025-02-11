using UnderSound;
using UnderSound.Exercícios;
using UnderSound.Exercícios.SistemaBanco;
using UnderSound.Exercícios.SistemaCatalogoJogos;
using UnderSound.Exercícios.SistemaEstoque;

/*Album albumDoSkillet = new Album("Rise");

Genero generoRock = new Genero();
generoRock.NomeGenero = "Rock";

Banda skillet = new Banda("Skillet");
skillet.AdicionarAlbum(albumDoSkillet);
skillet.ExibirDiscografia();


Musica musica1 = new Musica(skillet, "Rise")
{
	Duracao = 213,
	Disponivel = true,
	Genero = generoRock,
};

Musica musica2 = new Musica(skillet, "Sick of It")
{
	Duracao = 190,
	Genero = generoRock
};

albumDoSkillet.AdicionarMusica(musica1);
albumDoSkillet.AdicionarMusica(musica2);
skillet.AdicionarAlbum(albumDoSkillet);
albumDoSkillet.ExibirMusicasDoAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
skillet.ExibirDiscografia();
*/

Jogo Battlefield = new Jogo("Battlefield", "FPS", 9000);
Jogo.AdicionarJogo(Battlefield);
Battlefield.ExibirInformacoes();


/*Instanciando Conta com Construtor
Conta conta = new Conta(1, new Titular("Kamila Cardoso Mendes", "900.451.233-25", "Ararangua, rua das palmeiras, 109"), "teclado1234", 15000, 101, 30000, "C-104");
Console.WriteLine(conta.Informacoes);
*/

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



using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarMusica : Menu
{
    public override void Executar(DAL<Artista> artistaDal)
    {
        base.Executar(artistaDal);
        ExibirTituloDaOpcao("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nomeDoArtista = Console.ReadLine()!;
        Artista artistaRecup = artistaDal.RecuperarPor(a => a.Nome.Equals(nomeDoArtista));
        if (artistaRecup is not null)
        {
            Console.Write("Agora digite o título da música: ");
            string tituloDaMusica = Console.ReadLine()!;
            Console.Write("Agora digite o ano de lançamento da música: ");
            string anoLancamento = Console.ReadLine()!;
            artistaRecup.AdicionarMusica(new Musica(tituloDaMusica) {AnoLancamento = Convert.ToInt32(anoLancamento) });
            Console.WriteLine($"A música {tituloDaMusica} de {nomeDoArtista} foi registrada com sucesso!");
            artistaDal.Atualizar(artistaRecup);
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

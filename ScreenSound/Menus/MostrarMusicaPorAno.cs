using ScreenSound.Banco;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus
{
  internal class MostrarMusicaPorAno: Menu
  {
    public override void Executar(DAL<Artista> artistaDal)
    {
      base.Executar(artistaDal);
      ExibirTituloDaOpcao("Músicas por ano de lançamento");
      Console.Write("Digite o ano de lançamento ");
      int anolancamento = Convert.ToInt32(Console.ReadLine()!);
      DAL<Musica> musica = new(new ScreenSoundContext());
      var musicas = musica.BuscarPor(a => a.AnoLancamento.Equals(anolancamento));
      if (musicas is not null)
      {
        Console.WriteLine($"\nMúsicas lançadas no ano de {anolancamento}");
        foreach (var item in musicas)
        {
          Console.WriteLine(item);  
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
      }
      else
      {
        Console.WriteLine($"\nNenhuma música foi encontrada para o ano de {anolancamento}!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
      }
    }
  }
}

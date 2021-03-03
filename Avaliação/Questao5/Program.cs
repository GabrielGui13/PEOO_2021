using System;

public class Musica {
  public string nome;
  public string artista;
  public string duracao;
  public string pegarInfo(string entNome, string entArtista, string entDuracao) {
    nome = entNome;
    artista = entArtista;
    duracao = entDuracao;
  }
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetArtista(string artista) {
    this.artista = artista;
  }
  public void SetDuracao(string duracao) {
    if(int.Parse(duracao.Substring(0, 2)) > 0 || int.Parse(duracao.Substring(3, 2)) > 0) this.duracao = duracao;
  }
  public string GetNome() {
    return nome;
  }
  public string GetArtista() {
    return artista;
  }
  public string GetDuracao() {
    return duracao;
  }
}

public class Playlist {
    Musica[] instanciaMusica = new Musica;
    string[] musica = new string
    private int indice = 0;

    public static double Inserir(string getSong) {
        setMusica[indice] = getSong;
        indice++;
    }

    public static string retornarMusicas() {
        foreach (var cadaMusica in setMusica) {
            return cadaMusica;
        }
    }
    public string GetDuracaoTotal() {
        int minutos = 0;
        int segundos = 0;
        for (int i = 0; i < indice; i++) {
        minutos += int.Parse((setMusica[i].GetDuracao()).Substring(0,2));
        segundos += int.Parse((setMusica[i].GetDuracao()).Substring(3,2));  

        int horas = minutos/60;
        minutos %= 60;
        minutos += segundos / 60;
        segundos %= 60;
        return $"A duração total das músicas da playlist é de {horas} horas, {minutos} minutos e {segundos} segundos";
    }

    
  } 
}

public class MainClass {
  public static void Main() {
    Playlist playlist = new Playlist();

    Musica m1 = new Musica();
    m1.pegarInfo("If i Fell", "The Beatles", "02:19");
    playlist.Inserir(m1);

    Musica m2 = new Musica();
    m2.pegarInfo("Papagaio Reginaldo", "Palavra Cantada", "06:29");
    playlist.Inserir(m2);

    Console.WriteLine(playlist.GetDuracaoTotal());
    Console.WriteLine(playlist.retornarMusicas());
  }
}
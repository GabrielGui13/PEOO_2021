using System;
public class Musica {
  public string nome;
  public string artista;
  public string duracao;
  public Musica(string xnome, string xartista, string xduracao) {
    nome = xnome;
    artista = xartista;
    duracao = xduracao;
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
  Musica[] musicas = new Musica[19];
  private int aux = 0;
  public void InserirMusica(Musica m) {
    musicas[aux] = m;
    aux++;
  }
  
  public string GetDuracaoTotal() {
    int min = 0;
    int seg = 0;

    for(int i = 0; i < aux; i++) {
      min += int.Parse((musicas[i].GetDuracao()).Substring(0,2));
      seg += int.Parse((musicas[i].GetDuracao()).Substring(3,2));  
    }
    int hr = min/60;
    min %= 60;
    min += seg / 60;
    seg %=  60;
    return $"A playlist tem um total de {hr} horas, {min} minutos e {seg} segundos acumulados em musicas.";
  } 

  public string retornarMusicas(){
    int total = aux;
    string getBack = "As musicas inseridas na playlist sao: " ;
    for(int y = 0; y < total; y++){
      if (y < total && y != 0) getBack += ", ";
      if (y == total - 1) getBack += "e ";
      getBack += ($"{musicas[y].GetNome()}");
    }
    getBack += ".";
    return getBack;
  }
}

public class MainClass {
  public static void Main() {
    Playlist getPlaylist = new Playlist();
    Musica music1 = new Musica("Next to Me", "Imagine Dragons", "03:50");
    getPlaylist.InserirMusica(music1);
    Musica music2 = new Musica("XO", "John Mayer", "03:33");
    getPlaylist.InserirMusica(music2);
    Musica music3 = new Musica("One", "Ed Sheeran", "04:12");
    getPlaylist.InserirMusica(music3);
    Musica music4 = new Musica("Hear me", "Imagine Dragons", "03:55");
    getPlaylist.InserirMusica(music4);
    Musica music5 = new Musica("Feel Good Inc", "Gorillaz", "03:42");
    getPlaylist.InserirMusica(music5);

    Console.WriteLine(getPlaylist.GetDuracaoTotal());
    Console.WriteLine(getPlaylist.retornarMusicas());
  }
}
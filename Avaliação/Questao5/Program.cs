using System;

public class Musica {
  public string nome;
  public string artista;
  public string duracao;
  public Musica(string entnome, string entartista, string entduracao) {
    nome = entnome;
    artista = entartista;
    duracao = entduracao;
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
  Musica[] vetormusicas = new Musica[19];
  private int aux = 0;
  public void InserirMusica(Musica m) {
    vetormusicas[aux] = m;
    aux++;
  }
  public override string ToString() {
    return $"{{{vetormusicas[0].GetNome()}, {vetormusicas[1].GetNome()}}}";
  }
  public string GetDuracaoTotal() {
    int minutos = 0;
    int segundos = 0;
    for(int i = 0; i < aux; i++) {
      minutos += int.Parse((vetormusicas[i].GetDuracao()).Substring(0,2));
      segundos += int.Parse((vetormusicas[i].GetDuracao()).Substring(3,2));  
    }
    int horas = minutos/60;
    minutos %= 60;
    minutos += segundos / 60;
    segundos %=  60;
    return $"A duração total das músicas da playlist é de {horas} horas, {minutos} minutos e {segundos} segundos";
  } 
}

public class MainClass {
  public static void Main() {
    Playlist um = new Playlist();
    Musica m1 = new Musica("If i Fell", "The Beatles", "02:19");
    um.InserirMusica(m1);
    Musica m2 = new Musica("Papagaio Reginaldo", "Palavra Cantada", "06:29");
    um.InserirMusica(m2);
    Console.WriteLine(um.GetDuracaoTotal());
    Console.WriteLine(um.ToString());
  }
}
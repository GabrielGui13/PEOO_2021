using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args) {
            
            Playlist x = new Playlist("Ed", "Musicas de Ed Sheeran");
            Musica m1 = new Musica("What do I Know", "Ed Sheeran", "Divide", DateTime.Now, new TimeSpan(0, 03, 57));
            x.inserir(m1);
            Musica m2 = new Musica("Small Bump", "Ed Sheeran", "Multiply", DateTime.Now, new TimeSpan(0, 04, 19));
            x.inserir(m2);
            Musica m3 = new Musica("One", "Ed Sheeran", "Multiply", DateTime.Now, new TimeSpan(0, 04, 13));
            x.inserir(m3);
            Musica m4 = new Musica("Afterglow", "Ed Sheeran", "None", DateTime.Now, new TimeSpan(0, 03, 05));
            x.inserir(m4);
            Console.WriteLine(x);
        }
    }
    class Musica {
        private string titulo, artista, album;
        private DateTime dataInclusao;
        private TimeSpan duracao;
        public Musica(string t, string a, string al, DateTime da, TimeSpan du) {
            this.titulo = t;
            this.artista = a;
            this.album = al;
            this.dataInclusao = da;
            this.duracao = du;
        }
        public string getTitulo() {
            return this.titulo;
        }
        public string getArtista() {
            return this.artista;
        }
        public string getAlbum() {
            return this.album;
        }
        public DateTime getData() {
            return this.dataInclusao;
        }
        public TimeSpan getDuracao() {
            return this.duracao;
        }
        public override string ToString() {
            return $"{getTitulo()} \n{getArtista()} \n{getAlbum()} \n{getData()} \n{getDuracao()}";
        }
    }
    class Playlist {
        private string nome, descricao;
        private Musica[] musicas;
        private int aux = 0;
        public Playlist (string nome, string descricao) {
            this.nome = nome;
            this.descricao = descricao;
            this.musicas = new Musica[0];
        }
        public void inserir(Musica m) {
            if (aux == musicas.Length) Array.Resize(ref musicas, aux + 1);
            musicas[aux] = m;
            aux++;
        }
        public TimeSpan tempoTotal() {
            TimeSpan total = musicas[0].getDuracao();

            for (int i = 1; i < aux; i++) {
                total = total + musicas[i].getDuracao();
            }

            return total;
        } 
        public Musica[] listar() {
            return this.musicas;
        }
        public string retornarMusicas() {
            string mostrarMusicas = $"Playlist {nome} = ";

            for (int i = 0; i < musicas.Length; i++) {
                if (i != musicas.Length - 1) mostrarMusicas += musicas[i].getTitulo() + ", ";
                else mostrarMusicas += musicas[i].getTitulo() + ".";
            }

            return mostrarMusicas;
        }

        public override string ToString() {
            return $"Playlist = {nome} \nDescricao = {descricao} \n{aux} musicas \nTempo = {(tempoTotal().Hours == 0 ? "" : tempoTotal().Hours + "h ")}{tempoTotal().Minutes}min {tempoTotal().Seconds}seg" ;
        }
    }
}

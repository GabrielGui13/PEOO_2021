using System;
 
namespace Revisao03 {
    class Program {
        static void Main(string[] args) {
            Livraria x = new Livraria("Edson Livros");
            Livro l1 = new Livro("Harry Potter", "Infantil", 39.99);
            x.Inserir(l1);
            Livro l2 = new Livro("Edson a arte da cabeça", "Conhecimento", 29.99);
            x.Inserir(l2);
            Livro l3 = new Livro("Bruce: A Lenda", "Terror", 39.99);
            x.Inserir(l3);
            foreach (var y in x.Top10Vendidos()) Console.WriteLine(y);
        }
    }
    class Livro : IComparable {
        private string titulo, genero;
        private double preco;
        private int vendidos;
        public string Titulo {get => titulo;}
        public int Vendidos {get => vendidos;}
        public Livro(string t, string g, double p) {
            titulo = t;
            genero = g;
            if (p>=0) preco = p;
        }
        public int CompareTo(object obj) {
            Livro livro1 = this;
            Livro livro2 = (Livro) obj;
            if (livro1.vendidos != livro2.vendidos) return - livro1.vendidos.CompareTo(livro2.vendidos);
            else return livro1.titulo.CompareTo(livro2.titulo);
        }

        public string GetGenero() {
            return genero;
        }
        public void Vender() {
            vendidos++;
        }
        public override string ToString() {
            return $"Titulo: {titulo}, Genero: {genero}";
        }
    }
    class Livraria{
        private string nome;
		private int qtd;
        public int Qtd {get => qtd;}
        private Livro[] livros;
        public Livraria(string nome) {
            this.nome = nome;
			this.qtd = 0;
			this.livros = new Livro[100];
        }
        public void Inserir(Livro livro) {
            int posicao = Array.IndexOf(livros, livro);
            if (posicao < 0) {
                livros[qtd] = livro;
                qtd++;
            }
        }
        public void Remover(Livro livro) {
            int posicao = Array.IndexOf(livros, livro);
            if (posicao > -1) {
                livros[posicao] = livros[qtd - 1];
                livros[qtd - 1] = null;
                qtd--;
			}
		}

		private Livro[] Copia(Livro[] lista, int quantidade) {
			Livro[] novaLista = new Livro[quantidade];
			Array.Copy(lista, novaLista, quantidade);
            Array.Sort(novaLista);
			return novaLista;
		}

        public Livro[] Listar(){
			return Copia(livros, qtd);
        }

        public Livro[] ListarGenero(string genero){
            Livro[] lista = new Livro[100];
            int q = 0;
            foreach(Livro livro in livros) {
                if (livro.GetGenero() == genero) {
                    lista[q] = livro;
                    q++;
                }
            }
            return Copia(lista, q);
		}

        public Livro[] Top10Vendidos() {
			Livro[] lista = Copia(livros, qtd);
			return Copia(lista, qtd < 10 ? qtd : 10);
		}

        public override string ToString() {
            return $"{nome} {qtd} {Qtd}";
        }
    }
}

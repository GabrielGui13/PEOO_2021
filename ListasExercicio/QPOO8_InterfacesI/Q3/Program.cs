using System;
using System.Collections;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1;
            Loja gplays = new Loja {Nome = "Gplays"};
            Aplicativo a1 = new Aplicativo {Nome = "G-Fit", Categoria = "Fitness", Preco = Convert.ToDecimal(1.99), Curtidas = 10};
            Aplicativo a2 = new Aplicativo {Nome = "Netflix", Categoria = "Multimidia", Preco = Convert.ToDecimal(5.59), Curtidas = 25};
            Aplicativo a3 = new Aplicativo {Nome = "Facebook", Categoria = "Social", Preco = Convert.ToDecimal(3.99), Curtidas = 5};
            Aplicativo a4 = new Aplicativo {Nome = "Whatsapp", Categoria = "Social", Preco = Convert.ToDecimal(0.00), Curtidas = 50};
            gplays.Inserir(a1);
            gplays.Inserir(a2);
            gplays.Inserir(a3);
            gplays.Inserir(a4);

            foreach (Aplicativo i in gplays.Top10MaisCurtidos()) {
                Console.Write(aux);
                Console.Write(". ");
                Console.Write(i);
                Console.Write("\n");
                aux++;
            }
        }
    }
    class Loja {
        private Aplicativo[] apps;
        private int k;
        public string Nome {
            get; set;
        }
        public int Qtd {
            get {return k;}
        }
        public Loja() {
            this.apps = new Aplicativo[0];
        }
        public void Inserir(Aplicativo a) {
            if (k == apps.Length) Array.Resize(ref apps, k + 1);
            apps[k] = a;
            k++;
        }
        public void Excluir(Aplicativo a) {
            int posicao = Array.IndexOf(apps, a);
            for (int i = posicao; i < apps.Length; i++) {
                if (i == apps.Length - 1) break;
                apps[i] = apps[i + 1];
            }
            Array.Resize(ref apps, k - 1);
            k--;
        }
        public Aplicativo[] Listar() {
            Array.Sort(apps);
            return apps;
        }
         public Aplicativo[] Pesquisar(string cat) {
            int aux = 0;

            for (int i = 0; i < apps.Length; i++) {
                if (apps[i].Categoria.ToLower() == cat.ToLower()) {
                    aux++;
                }
            }

            Aplicativo[] pesquisa = new Aplicativo[aux];
            aux = 0;

            for (int i = 0; i < apps.Length; i++) {
                if(apps[i].Categoria.ToLower() == cat.ToLower()) {
                    pesquisa[aux] = apps[i];
                    aux++;
                }
            }
            Array.Sort(pesquisa);
            return pesquisa;
        }
        public Aplicativo[] ListarPreco() {
            Array.Sort(apps, new PrecoComp());
            return apps;
        }
        public Aplicativo[] Top10MaisCurtidos() {
            Array.Sort(apps, new CurtidasComp());
            return apps;
        }
    }
    class Aplicativo : IComparable {
        private int curtidas;
        public string Nome {
            get; set;
        }
        public string Categoria {
            get; set;
        }
        public decimal Preco {
            get; set;
        }
        public int Curtidas {
            set {curtidas = value;}
            get {return curtidas;}
        }
        public void Curtir() {
            curtidas++;
        }
        public int CompareTo(object obj) {
            Aplicativo x = this;
            Aplicativo y = (Aplicativo) obj;
            return x.Nome.CompareTo(y.Nome);
        }
        public override string ToString() {
            return $"{Nome} {Categoria} {Preco} {Curtidas}";
        }
    }
    class PrecoComp : IComparer {
        public int Compare(object x1, object y1) {
            Aplicativo x = (Aplicativo) x1;
            Aplicativo y = (Aplicativo) y1;
            return x.Preco.CompareTo(y.Preco);
        }
    }
    class CurtidasComp : IComparer {
        public int Compare(object x1, object y1) {
            Aplicativo x = (Aplicativo) x1;
            Aplicativo y = (Aplicativo) y1;
            return -x.Curtidas.CompareTo(y.Curtidas);
        }
    }

}

using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Loja gplays = new Loja {Nome = "gplays"};
            Aplicativo x1 = new Aplicativo {Nome = "G-Fit", Categoria = "Fit", Preco = Convert.ToDecimal(5.59)};
            Aplicativo x2 = new Aplicativo {Nome = "Carbon Diet", Categoria = "Fit", Preco = Convert.ToDecimal(3.99)};
            Aplicativo x3 = new Aplicativo {Nome = "Sei nao", Categoria = "Confuso", Preco = Convert.ToDecimal(0.99)};
            gplays.Inserir(x1);
            gplays.Inserir(x2);
            gplays.Inserir(x3);
            gplays.Excluir(x2);
            Console.WriteLine(gplays.retornarAplicativo(2, "fit"));
        }
    }
    class Aplicativo {
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
            get {return curtidas;}
        }
        public void Curtir() {
            curtidas++;
        }
        public override string ToString()
        {
            return $"{Nome} {Categoria} {Preco} {Curtidas}";
        }
    }
    class Loja {
        private Aplicativo[] apps;
        private int k = 0;
        public Loja() {
            this.apps = new Aplicativo[0];
        } 
        public string Nome {
            get; set;
        }
        public int Qtd {
            get {return k;}
        }
        public void Inserir(Aplicativo app) {
            if (k == apps.Length) Array.Resize(ref apps, k + 1);
            apps[k] = app;
            k++;
        }
        public void Excluir(Aplicativo app) {
            int posicao = Array.IndexOf(apps, app);
            for (int i = posicao; i < apps.Length; i++) {
                if (i == apps.Length - 1) break;
                apps[i] = apps[i + 1];
            }
            Array.Resize(ref apps, k - 1);
            k--;
        }
        public Aplicativo[] Listar() {
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

            return pesquisa;
        }
        public string retornarAplicativo(int seletor, string cat) {
            string retorno = "";

            if (seletor == 1) {
                retorno = "Todos os apps = ";
                for (int i = 0; i < apps.Length; i++) {
                    if (i != apps.Length - 1) retorno += apps[i].Nome + ", ";
                    else retorno += apps[i].Nome + "."; 
                }
                if (retorno == "Todos os apps = ") retorno += "Nenhum";
            }
            else if (seletor == 2) {
                retorno = $"Categoria {cat} = ";
                for (int i = 0; i < Pesquisar(cat).Length; i++) {
                    if (i != Pesquisar(cat).Length - 1) retorno += Pesquisar(cat)[i].Nome + ", ";
                    else retorno += Pesquisar(cat)[i].Nome + "."; 
                }
                if (retorno == $"Categoria {cat} = ") retorno = "Categoria = Nenhum";
            }
            else retorno = "Ocorreu um erro";

            return retorno;
        }
        public override string ToString()
        {
            return $"{Nome} {Qtd}";
        }
    }
}

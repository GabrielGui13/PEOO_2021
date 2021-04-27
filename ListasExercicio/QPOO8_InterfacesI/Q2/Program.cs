using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadroMedalhas quadro = new QuadroMedalhas();
            Pais brasil = new Pais("Brasil", 3, 0, 0);
            Pais eua = new Pais("EUA", 3, 0, 2);
            Pais japao = new Pais("Japão", 3, 0, 1);
            Pais alemanha = new Pais("Alemanha", 3, 0, 0);
            Pais coreia = new Pais("Coreia do Sul", 3, 0, 0);
            quadro.Inserir(brasil);
            quadro.Inserir(eua);
            quadro.Inserir(japao);
            quadro.Inserir(alemanha);
            quadro.Inserir(coreia);
            foreach (Pais i in quadro.Listar()) {
                Console.WriteLine(i);
            }
        }
    }
    class QuadroMedalhas
    {
        private Pais[] paises;
        private int aux;
        public QuadroMedalhas() {
            this.paises = new Pais[0];
        }
        public void Inserir(Pais p) {
            if (aux == paises.Length) Array.Resize(ref paises, aux + 1);
            paises[aux] = p;
            aux++;
        }
        public Pais[] Listar() {
            Array.Sort(paises);
            return paises;
        }

    }
    class Pais : IComparable {
        private string nome;
        private int ouro, prata, bronze;
        public Pais(string n, int o, int p, int b) {
            this.nome = n;
            this.ouro = o;
            this.prata = p;
            this.bronze = b;
        }
        public int CompareTo(object obj) {
            Pais pais1 = this;
            Pais pais2 = (Pais) obj;
        
            if (pais1.ouro != pais2.ouro) return -pais1.ouro.CompareTo(pais2.ouro);
            else if(pais1.ouro == pais2.ouro && pais1.prata != pais2.prata) return -pais1.prata.CompareTo(pais2.prata);
            else if(pais1.ouro == pais2.ouro && pais1.prata == pais2.prata && pais1.bronze != pais2.bronze) return -pais1.bronze.CompareTo(pais2.bronze);
            else return pais1.nome.CompareTo(pais2.nome);
        }
        public override string ToString() {
            return $"Pais = {nome}";
        }
    }
}
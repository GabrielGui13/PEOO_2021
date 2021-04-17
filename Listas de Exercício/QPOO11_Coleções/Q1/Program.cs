using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadroMedalhas<Pais> tabela = new QuadroMedalhas<Pais>();
            
            Pais brasil = new Pais{Nome = "Brasil", Ouro = 5, Prata = 5, Bronze = 1};
            Pais japao = new Pais{Nome = "Japão", Ouro = 5, Prata = 5, Bronze = 1};
            Pais alemanha = new Pais{Nome = "Alemanha", Ouro = 5, Prata = 5, Bronze = 1};
            tabela.Inserir(brasil);
            tabela.Inserir(japao);
            tabela.Inserir(alemanha);

            foreach (Pais p in tabela) {
                Console.WriteLine(p);
            }
        }
    }
    class QuadroMedalhas<P> : IEnumerable {
        private List<P> paises = new List<P>();
        public void Inserir (P p) {
            paises.Add(p);
        }
        public void Remover (P p) {
            int posicao = paises.IndexOf(p);
            paises.RemoveAt(posicao);
        }
        public IEnumerator GetEnumerator() {
            paises.Sort();
            return paises.GetEnumerator();
        }
    }
    class Pais : IComparable<Pais> {
        private string nome;
        private int ouro, prata, bronze;
        public string Nome {
            get {return nome;}
            set {nome = value;}
        }
        public int Ouro {
            get {return ouro;}
            set {ouro = value;}
        }
        public int Prata {
            get {return prata;}
            set {prata = value;}
        }
        public int Bronze {
            get {return bronze;}
            set {bronze = value;}
        }
        public int CompareTo(Pais x) {
            if (Ouro != x.Ouro) return -Ouro.CompareTo(x.Ouro);
            else if (Ouro == x.Ouro && Prata != x.Prata) return -Prata.CompareTo(x.Prata);
            else if (Prata == x.Prata && Prata == x.Prata && Bronze != x.Bronze) return -Bronze.CompareTo(x.Bronze);
            else return Nome.CompareTo(x.Nome);
        }
        public override string ToString()
        {
            return $"País = {Nome}";
        }
    }
}

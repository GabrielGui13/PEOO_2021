using System;
using System.Collections;
using System.Linq;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coleção<Aluno> escola = new Coleção<Aluno>();
            Aluno x = new Aluno{Nome = "Gabriel", Idade = 18, Nascimento = new DateTime(2002, 08, 13)};
            Aluno y = new Aluno{Nome = "Guilherme", Idade = 15, Nascimento = new DateTime(2005, 12, 13)};
            Aluno z = new Aluno{Nome = "Rafaela", Idade = 18, Nascimento = new DateTime(2003, 04, 10)};
            escola.Add(x);
            escola.Add(y);
            escola.Add(z);

            foreach (Aluno i in escola) {
                Console.WriteLine(i);
            }
        }
    }
    class Coleção<T> : IEnumerable {
        private T[] objs = new T[0];
        private int k;
        public int Count {
            get{return k;}
        }
        public void Add(T obj) {
            if (Count == objs.Length) Array.Resize(ref objs, Count + 1);
            objs[Count] = obj;
            k++;
        }
        public void Remove(T obj) {
            int posicao = Array.IndexOf(objs, obj);
            for (int i = posicao; i < objs.Length; i++) {
                if (i == objs.Length - 1) break;
                objs[i] = objs[i + 1];
            }
            Array.Resize(ref objs, Count - 1);
            k--;
        }
        public void Sort() {
            Array.Sort(objs, new AlunoNascimentoComp());
        }
        public IEnumerator GetEnumerator() {
            this.Sort();
            return objs.GetEnumerator();
        }
    }
    class Aluno : IComparable<Aluno> {
        public string Nome {
            get; set;
        }
        public int Idade {
            get; set;
        }
        public DateTime Nascimento {
            get; set;
        }
        public int CompareTo(Aluno a) {
            return Nome.CompareTo(a.Nome);
        }
        public override string ToString()
        {
            return $"{Nome} {Idade} {Nascimento.ToString("dd/MM/yyyy")}";
        }
    }
    class AlunoNascimentoComp : IComparer {
        public int Compare(object a, object b) {
            Aluno x = (Aluno) a;
            Aluno y = (Aluno) b;
            return -x.Nascimento.CompareTo(y.Nascimento);
        }
    }
}

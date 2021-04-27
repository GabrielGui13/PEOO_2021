using System;
using System.Collections;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno {Nome = "Gabriel", Matricula = "1111", Nascimento = new DateTime(2002, 08, 13)};
            Aluno a2 = new Aluno {Nome = "Rafaela", Matricula = "1110", Nascimento = new DateTime(2003, 04, 10)};
            Aluno a3 = new Aluno {Nome = "Guilherme", Matricula = "1113", Nascimento = new DateTime(2005, 12, 13)};
            Aluno[] alunos = {a1, a2, a3};
            int aux = int.Parse(Console.ReadLine());
            if (aux == 1) Array.Sort(alunos, new AlunoMatriculaComp());
            else if (aux == 2) Array.Sort(alunos, new AlunoNascimentoComp());
            else Array.Sort(alunos);

            foreach (Aluno i in alunos) {
                Console.WriteLine(i);
            }
        }
    }
    class Aluno : IComparable {
        public string Nome {
            get; set;
        }
        public string Matricula {
            get; set;
        }
        public DateTime Nascimento {
            get; set;
        }
        public int CompareTo(object obj) {
            Aluno x = this;
            Aluno y = (Aluno) obj;
            return x.Nome.CompareTo(y.Nome);
        }
        public override string ToString() {
            return $"{Nome} {Matricula} {Nascimento.ToString("dd/MM/yyyy")}";
        }
    }
    class AlunoNascimentoComp : IComparer {
        public int Compare (object x, object y) {
            Aluno obj1 = (Aluno) x;
            Aluno obj2 = (Aluno) y;
            return -obj1.Nascimento.CompareTo(obj2.Nascimento);
        }
    }
    class AlunoMatriculaComp : IComparer {
        public int Compare (object x, object y) {
            Aluno obj1 = (Aluno) x;
            Aluno obj2 = (Aluno) y;
            return obj1.Matricula.CompareTo(obj2.Matricula);
        }
    }
}

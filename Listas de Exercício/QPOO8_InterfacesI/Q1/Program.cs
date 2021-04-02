using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno{Nome = "Gabriel", Matricula = "1111", Nascimento = new DateTime(2002, 08, 13)};
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
    }
}

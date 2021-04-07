using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class DisciplinaAnual : IDisciplina {
        private string nome;
        private int nota1, nota2, nota3, nota4, notaFinal;
        public DisciplinaAnual(string n, int n1, int n2, int n3, int n4, int nf) {
            this.nome = n;
            this.nota1 = n1;
            this.nota2 = n2;
            this.nota3 = n3;
            this.nota4 = n4;
            this.notaFinal = nf;
        }
        public string getNome() {
            return nome;
        }
        public int calcMediaParcial() {
            int media1 = (n1 + n2) * 2 + (n3 + n4) * 3;
            int media2 = n1 + n2 + n3 + n4;
            return media1 / media2; 
        }
        public int calcMediaFinal() {
            return;
        }
    }
    class DisciplinaSemestral : IDisciplina {
        private string nome;
        private int nota1, nota2, notaFinal;
        public DisciplinaAnual(string n, int n1, int n2, int nf) {
            this.nome = n;
            this.nota1 = n1;
            this.nota2 = n2;
            this.notaFinal = nf;
        }
        public string getNome() {
            return nome;
        }
        public int calcMediaParcial() {
            int media1 = n1 * 2 + n2 * 3;
            int media2 = n1 + n2;
            return media1 / media2; 
        }
        public int calcMediaFinal() {
            return;
        }
    }
    interface IDisciplina {
        public string getNome();
        public int calcMediaParcial();
        public int calcMediaFinal();
    }

}

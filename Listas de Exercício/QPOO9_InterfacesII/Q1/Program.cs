using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisciplina x = new DisciplinaAnual("Gabriel", 5, 6, 7, 7, 8);
            IDisciplina y = new DisciplinaSemestral("Gabriel", 7, 2, 9);
            Console.WriteLine(x.getNome());
            Console.WriteLine(x.calcMediaParcial());
            Console.WriteLine(x.calcMediaFinal() + "\n");
            Console.WriteLine(y.getNome());
            Console.WriteLine(y.calcMediaParcial());
            Console.WriteLine(y.calcMediaFinal());
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
            int media = (nota1 + nota2) * 2 + (nota3 + nota4) * 3;
            return media / 10; 
        }
        public int calcMediaFinal() {
            return (calcMediaParcial() + notaFinal) / 2;
        }
        public override string ToString()
        {
            return $" Nota 1 = {nota1}\n Nota 2 = {nota2}\n Nota 3 = {nota3}\n Nota 4 = {nota4}\n Media Parcial = {calcMediaParcial()}\n\n Nota Final = {notaFinal}\n Media Final = {calcMediaFinal()}";
        }
    }
    class DisciplinaSemestral : IDisciplina {
        private string nome;
        private int nota1, nota2, notaFinal;
        public DisciplinaSemestral(string n, int n1, int n2, int nf) {
            this.nome = n;
            this.nota1 = n1;
            this.nota2 = n2;
            this.notaFinal = nf;
        }
        public string getNome() {
            return nome;
        }
        public int calcMediaParcial() {
            int media = nota1 * 2 + nota2 * 3;
            return media / 5;
        }
        public int calcMediaFinal() {
            return (calcMediaParcial() + notaFinal) / 2;
        }
        public override string ToString() {
            return $" Nota 1 = {nota1}\n Nota 2 = {nota2}\n Media Parcial = {calcMediaParcial()}\n\n Nota Final = {notaFinal}\n Media Final = {calcMediaFinal()}";
        }
    }
    interface IDisciplina {
        string getNome();
        int calcMediaParcial();
        int calcMediaFinal();
    }

}

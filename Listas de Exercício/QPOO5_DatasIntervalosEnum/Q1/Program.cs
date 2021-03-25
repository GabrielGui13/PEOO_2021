using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Paciente Gabriel = new Paciente("Gabriel", "097.819.644-99", "(84)99911-0101", new DateTime(2002, 08, 13));
            Paciente Gui = new Paciente("Guilherme", "097.819.644-99", "(84)99911-0101", new DateTime(2005, 05, 27));
            Paciente Lav = new Paciente("Rafaela", "097.819.644-99", "(84)99911-0101", new DateTime(2003, 04, 10));

            Console.WriteLine(Gabriel.idade());
            Console.WriteLine(Gui.idade());
            Console.WriteLine(Lav.idade());
        }
    }
    class Paciente {
        private string nome, cpf, telefone;
        private DateTime nascimento;

        public Paciente(string n, string c, string t, DateTime nasc) {
            this.nome = n;
            this.cpf = c;
            this.telefone = t;
            this.nascimento = nasc;
        }
        public string idade() {
            DateTime atual = DateTime.Now;
            int anoAtual = atual.Year;
            int mesAtual = atual.Month;
            int diaAtual = atual.Day;

            int anoPaciente = nascimento.Year; 
            int mesPaciente = nascimento.Month;
            int diaPaciente = nascimento.Day;

            int anoAniv = anoAtual - anoPaciente;
            int mesAniv = mesAtual - mesPaciente;

            if (mesAniv < 0) {
                anoAniv -= 1;
                mesAniv += 12;
            }

            return $"{anoAniv} anos e {mesAniv} mes(es)";
        }
        public override string ToString()
        {
            return $"{nome} {cpf} {telefone} {nascimento}";
        }

    }
}

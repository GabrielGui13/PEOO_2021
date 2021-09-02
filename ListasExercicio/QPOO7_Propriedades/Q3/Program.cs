using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente Gabriel = new Paciente{Nome = "Gabriel", CPF = "097.819.644-99", Telefone = "(84)99911-0101", Nascimento = new DateTime(2002, 08, 13)};
            Paciente y = new Paciente{Nome = "Guilherme", CPF = "097.819.644-99", Telefone = "(84)99911-0101", Nascimento = new DateTime(2005, 12, 13)};
            Console.WriteLine(Gabriel);
            Console.WriteLine(y);
            Console.WriteLine(y.Nome.Length);
        }
    }
    class Paciente {
        private string nome, cpf, telefone;
        private DateTime nascimento;
        public string Nome {
            get {return nome;}
            set {nome = value;}
        } 
        public string CPF {
            get {return cpf;}
            set {cpf = value;}
        }
        public string Telefone {
            get {return telefone;}
            set {if (value.Length > 0) telefone = value;}
        }
        public DateTime Nascimento {
            get {return nascimento;}
            set {nascimento = value;}
        }
        public string Idade {
            get {
                DateTime atual = DateTime.Now;
                int anoAtual = atual.Year;
                int mesAtual = atual.Month;
                int diaAtual = atual.Day;

                int anoPaciente = Nascimento.Year; 
                int mesPaciente = Nascimento.Month;
                int diaPaciente = Nascimento.Day;

                int anoAniv = anoAtual - anoPaciente;
                int mesAniv = mesAtual - mesPaciente;

                if (mesAniv < 0) {
                    anoAniv -= 1;
                    mesAniv += 12;
                }
                return $"Idade = {anoAniv} anos e {mesAniv} mes(es)";
            }
        }
        public override string ToString() {
            return $"Paciente = {Nome} \nCPF = {CPF} \nContato = {Telefone} \n{Idade} \n";
        }
    }
}

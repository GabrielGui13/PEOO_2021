using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {   
            DateTime GabrielNasc = new DateTime(2002, 08, 13);
            Paciente Gabriel = new Paciente("Gabriel", "097.819.644-99", "(84)99911-0101", GabrielNasc);

            DateTime GuiNasc = new DateTime(2005, 12, 13);
            Paciente Gui = new Paciente("Guilherme", "097.819.644-99", "(84)99911-0101", GuiNasc);

            DateTime LavNasc = new DateTime(2018, 02, 15);
            Paciente Lav = new Paciente("Lavinia", "097.819.644-99", "(84)99911-0101", LavNasc);

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
            int diaAtual = atual.Day;
            int mesAtual = atual.Month;
            int anoAtual = atual.Year;

            int anoPaciente = nascimento.Year; 
            int mesPaciente = nascimento.Month;
            int diaPaciente = nascimento.Day;

            int anoAniv = anoAtual - anoPaciente;
            int mesAniv = 0;

            if (mesAtual >= mesPaciente) {
                if (diaAtual >= diaPaciente) {
                    anoAniv = anoAtual - anoPaciente;
                    mesAniv = (mesPaciente - mesAtual) * -1;
                } 
                else {
                    anoAniv -= 1;
                    mesAniv = 12 - mesPaciente + mesAtual;
                    if (mesAniv < 0) mesAniv *= -1;
                    else mesAniv = 12 - mesPaciente + mesAtual;
                }
            }
            else {
                anoAniv -= 1;
                mesAniv = mesAtual - mesPaciente;
                mesAniv = 12 - mesPaciente + mesAtual;
                if (mesAniv < 0) mesAniv *= -1;
                else mesAniv = 12 - mesPaciente + mesAtual;
            } 

            return $"{anoAniv} anos e {mesAniv} mes(es)";
        }
        public override string ToString()
        {
            return $"{nome} {cpf} {telefone} {nascimento}";
        }

    }
}

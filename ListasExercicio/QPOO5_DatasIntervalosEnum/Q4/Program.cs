using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario gabriel = new Estagiario("Gabriel", "097.819.644-99", "(84) 99911-0101");
            gabriel.setTurno(3);
            gabriel.setDias(5);
            Console.WriteLine(gabriel);
        }
    }
    class Estagiario {
        private string nome, cpf, telefone;
        private Dias dias;
        private Turno turno;
        public Estagiario(string n, string c, string t) {
            this.nome = n;
            this.cpf = c;
            this.telefone = t;
        }
        public void setDias(int seletor) {
            switch (seletor) {
                case 1: this.dias = (Dias) 1; break;
                case 2: this.dias = (Dias) 3; break;
                case 3: this.dias = (Dias) 7; break;
                case 4: this.dias = (Dias) 15; break;
                case 5: this.dias = (Dias) 31; break;
            }
        }
        public void setTurno (int seletor) {
            this.turno = (Turno) seletor;
        }
        public Dias getDias() {
            return this.dias;
        }
        public Turno getTurno() {
            return this.turno;
        }
        public override string ToString()
        {
            return $"Nome = {nome} \nCPF = {cpf} \nTelefone = {telefone} \nDias = {getDias()} \nTurno = {getTurno()}";
        }
    }
    [Flags]
    enum Dias : int {
        nenhum = 0,
        segunda = 1,
        terça = 2,
        // 3 = segunda, terca
        quarta = 4,
        // 7 = segunda, terca, quarta
        quinta = 8,
        //15 = segunda, terca, quarta, quinta
        sexta = 16
        // 31 = segunda, terca, quarta, quinta, sexta
    }
    enum Turno : int {
        matutino = 1, vespertino = 2, noturno = 3
    }
}

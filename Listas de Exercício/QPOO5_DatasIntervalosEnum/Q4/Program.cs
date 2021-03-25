using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estagiario gabriel = new Estagiario("Gabriel", "097.819.644-99", "(84) 99911-0101");
            gabriel.setDias(1);
            gabriel.setTurno(3);
            Console.WriteLine(gabriel);
        }
    }
    class Estagiario {
        private string nome, cpf, telefone;
        private Dias dias;
        private Turno turno;
        private Dias[] armazenarDias = new Dias[5];
        public Estagiario(string n, string c, string t) {
            this.nome = n;
            this.cpf = c;
            this.telefone = t;
        }
        public void setDias(int seletor) {
            Random x = new Random();
            int diaEsc = x.Next(1, 6);

            switch (seletor) {
                case 1: armazenarDias[0] = (Dias) diaEsc; break;
                case 2: for (int i = 0; i < 5; i++) {
                    if (i == 0 || i == 2 || i == 4) continue;
                    armazenarDias[i] = (Dias) i + 1;
                }; break;
                case 3: for (int i = 0; i < 5; i++) {
                    if (i == 1 || i == 3) continue;
                    armazenarDias[i] = (Dias) i + 1;
                }; break;
                case 4: for (int i = 0; i < 5; i++) {
                    if (i == diaEsc) continue;
                    armazenarDias[i] = (Dias) i + 1;
                }; break;
                case 5: for (int i = 0; i < 5; i++) {
                    armazenarDias[i] = (Dias) i + 1;
                }; break;
            }
            
            for (int i = 0; i < armazenarDias.Length; i++) {
                this.dias = armazenarDias[i];
            }
        }
        public void setTurno (int seletor) {
            switch (seletor) {
                case 1: this.turno = (Turno) 1; break;
                case 2: this.turno = (Turno) 2; break;
                case 3: this.turno = (Turno) 3; break;
            }
        }
        public Dias getDias() {
            return this.dias;
        }
        public Turno getTurno() {
            return this.turno;
        }
        public override string ToString()
        {
            return $"Nome = {nome} \nCPF = {cpf} \nTelefone = {telefone} \nDias = {dias} \nTurno = {getTurno()}";
        }
    }
    enum Dias : int {
        segunda = 1, terça = 2, quarta = 3, quinta = 4, sexta = 5
    }
    enum Turno : int {
        matutino = 1, vespertino = 2, noturno = 3
    }
}

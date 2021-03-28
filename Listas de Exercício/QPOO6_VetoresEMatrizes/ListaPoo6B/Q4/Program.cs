using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args){
            
            Agenda x = new Agenda();
            Contato p1 = new Contato("Gabriel", "(84)99911-0101", new DateTime(2002, 08, 13));
            x.inserir(p1);
            Contato p2 = new Contato("Guilherme", "(84)99911-0101", new DateTime(2005, 12, 13));
            x.inserir(p2);
            Contato p3 = new Contato("Luciana", "(84)99911-0101", new DateTime(1970, 07, 04));
            x.inserir(p3);
            Contato p4 = new Contato("Marcio", "(84)99911-0101", new DateTime(1975, 06, 20));
            x.inserir(p4);
            Contato p5 = new Contato("Sonim", "(84)99911-0101", new DateTime(2002, 08, 01));
            x.inserir(p5);
            Contato p6 = new Contato("Sim", "(84)99911-0101", new DateTime(2002, 06, 01));
            x.inserir(p6);

            Console.WriteLine(x.retornarContato(2, 8));
        }
    }
    class Agenda {
        private Contato[] contatos;
        private int aux;
        public Agenda() {
            this.contatos = new Contato[0];
        }
        public void inserir(Contato c) {
            if (aux == contatos.Length) Array.Resize(ref contatos, aux + 1);
            contatos[aux] = c;
            aux++;
        }
        public Contato[] listar() {
            return this.contatos;
        } 
        public Contato[] aniversariantesMes(int m) {
            int aux2 = 0;
            Contato[] niverMes = new Contato[0];

            for (int i = 0; i < contatos.Length; i++) {
                if (contatos[i].getDate().Month == m) {
                    if (aux == contatos.Length) Array.Resize(ref niverMes, aux2 + 1);
                    niverMes[aux2] = contatos[i];
                    aux2++;
                }
            }
            return niverMes;
        }
        public string retornarContato(int c, int m) {
            string retorno = "";
            Contato[] anivMes = aniversariantesMes(m);

            if (c == 1) {
                retorno += "Contatos = ";
                for (int i = 0; i < contatos.Length; i++) {
                    if (i != contatos.Length - 1) retorno += contatos[i].getNome() + ", ";
                    else retorno += contatos[i].getNome() + ".";
                }
            }
            else if (c == 2) {
                retorno += "Aniversariantes do mes = ";
                for (int i = 0; i < anivMes.Length; i++) {
                    if (i != anivMes.Length - 1) retorno += anivMes[i].getNome() + ", ";
                    else retorno += anivMes[i].getNome() + ".";
                }
            }
            else retorno += "Algo de errado aconteceu!";

            return retorno;
        }
    }
    class Contato {
        private string nome, telefone;
        private DateTime nascimento;
        public Contato (string n, string t, DateTime nasc) {
            this.nome = n;
            this.telefone = t;
            this.nascimento = nasc;
        }
        public string getNome() {
            return nome;
        }
        public DateTime getDate() {
            return nascimento;
        }
        public override string ToString() {
            return $"{nome} \n{telefone} \n{nascimento.ToString("dd/MM/yyyy")}";
        }
    }
}

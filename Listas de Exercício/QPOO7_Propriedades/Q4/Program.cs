using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Compromisso x = new Compromisso {Assunto = "Aniversário de Rafaela", Local = "Casa de Rafaela", Data = new DateTime(2021, 04, 10)};
            Compromisso y = new Compromisso {Assunto = "Aniversário de Arthur", Local = "Casa de Arthur", Data = new DateTime(2021, 04, 07)};
            Compromisso z = new Compromisso {Assunto = "Aniversário de Catatau", Local = "Casa de Catatau", Data = new DateTime(2021, 04, 11)};
            Compromisso a = new Compromisso {Assunto = "Aniversário de Gabriel", Local = "Casa de Gabriel", Data = new DateTime(2021, 08, 13)};
            agenda.Inserir(x);
            agenda.Inserir(y);
            agenda.Inserir(z);
            agenda.Inserir(a);
            Console.WriteLine(agenda.retornarCompromisso(1, 4));
            agenda.Excluir(z);
            Console.WriteLine(agenda.retornarCompromisso(2, 4));
        }
    }
    class Compromisso {
        public string Assunto {get; set;}
        public string Local {get; set;}
        public DateTime Data {get; set;}

        public override string ToString() {
            return $"Compromisso = {Assunto} \nLocal = {Local} \nData = {Data.ToString("dd/MM/yyyy")}";
        }
    }
    class Agenda {
        private Compromisso[] comps;
        private int k = 0;
        public int Qtd {
            get {return k;}
        }
        public Agenda () {
            this.comps = new Compromisso[0];
        }
        public void Inserir(Compromisso c) {
            if (k == comps.Length) Array.Resize(ref comps, k + 1);
            comps[k] = c;
            k++;
        }
        public void Excluir(Compromisso c) {
            int posicao = Array.IndexOf(comps, c);
            for (int i = posicao; i < comps.Length; i++) {
                if (i == comps.Length - 1) break;
                comps[i] = comps[i + 1];
            }
            Array.Resize(ref comps, k - 1);
            k--;
        }
        public Compromisso[] Listar() {
            return comps;
        }
        public Compromisso[] Pesquisar(int mes) {
            int aux = 0;
            
            for (int i = 0; i < comps.Length; i++) {
                if (comps[i].Data.Month == mes) {
                    aux++;
                }
            }

            Compromisso[] pesquisa = new Compromisso[aux];
            aux = 0;

            for (int i = 0; i < comps.Length; i++) {
                if (comps[i].Data.Month == mes) {
                    pesquisa[aux] = comps[i];
                    aux++;
                }
            }

            return pesquisa;
        }
        public string retornarCompromisso(int aux, int mes) {
            string retorno = "";

            if (aux == 1) {
                retorno = "Compromissos = ";
                for (int i = 0; i < comps.Length; i++) {
                    if (i != comps.Length - 1) retorno += $"{comps[i].Assunto}({comps[i].Data.ToString("dd/MM/yyyy")}), ";
                    else retorno += $"{comps[i].Assunto}({comps[i].Data.ToString("dd/MM/yyyy")}).\n";
                }
                if (retorno == "Compromissos = ") retorno += "Nenhum";
            }
            if (aux == 2) {
                retorno = "Compromissos do mês = ";
                for (int i = 0; i < Pesquisar(mes).Length; i++) {
                    if (i != Pesquisar(mes).Length - 1) retorno += $"{Pesquisar(mes)[i].Assunto}({Pesquisar(mes)[i].Data.ToString("MM")}), ";
                    else retorno += $"{Pesquisar(mes)[i].Assunto}({Pesquisar(mes)[i].Data.ToString("MM")}).\n";
                }
                if (retorno == "Compromissos do mês = ") retorno += "Nenhum";
            }
            return retorno;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda a = new Agenda();
            try {
                Compromisso c1 = new Compromisso{Assunto = "Reuniao", Local = "Google Meet", Data = new DateTime(2021, 04, 28)};
                Compromisso c2 = new Compromisso{Assunto = "Casamento Gabriel e Rafaela", Local = "Praia", Data = new DateTime(2021, 12, 12)};
                Compromisso c3 = new Compromisso{Assunto = "Casamento Gabriel e Rafaela", Local = "Praia", Data = new DateTime(2021, 12, 12)};
                a.Inserir(c1);
                a.Inserir(c2);
                a.Inserir(c3);

                foreach (Compromisso c in a.Pesquisar(12, 2021 )) {
                    Console.WriteLine(c);
                    Console.WriteLine("\n");
                }
            }
            catch (InvalidOperationException e) {
                Console.WriteLine("Compromisso existente!");
                Console.WriteLine(e.Message);
            }
            catch (FormatException) {
                Console.WriteLine("Valor informado invalido");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("Fim");
            }
        }
    }
    class Compromisso {
        public string Assunto {
            get; set;
        }
        public string Local {
            get; set;
        }
        public DateTime Data {
            get; set;
        }
        public override string ToString()
        {
            return $"Assunto = {Assunto} \nLocal = {Local} \nData = {Data}";
        }
    }
    class Agenda {
        private List<Compromisso> comps = new List<Compromisso>();
        public int k;
        public int Qtd {
            get {return k;}
        }
        public void Inserir (Compromisso c) {
            for (int i = 0; i < k; i++) {
                if (comps[i].Assunto == c.Assunto && comps[i].Local == c.Local && comps[i].Data == c.Data) {
                    throw new InvalidOperationException();
                }
            }
            comps.Add(c);
            k++;
        } 
        public void Remover (Compromisso c) {
            comps.Remove(c);
        }
        public List<Compromisso> Listar() {
            return comps;
        }
        public List<Compromisso> Pesquisar(int mes, int ano) {
            List<Compromisso> filtro = new List<Compromisso>();
            int aux = 0;

            for (int i = 0; i < Qtd; i++) {
                if (comps[i].Data.Month == mes && comps[i].Data.Year == ano) {
                    filtro.Add(comps[i]);
                    aux++;
                }
            }
            if (aux == 0) Console.WriteLine("Sem compromissos!");
            return filtro;
        }
    }
}

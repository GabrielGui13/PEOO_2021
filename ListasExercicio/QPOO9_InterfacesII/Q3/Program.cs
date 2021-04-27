using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            ISorteio x = new Bingo(10);
            ISorteio y = new Mega();
            y.Proximo();
            y.Proximo();
            y.Proximo();
            y.Proximo();
            y.Proximo();
            y.Proximo();
            
            foreach (int i in x.Sorteados(1)) {
                if (i == 0) break;
                Console.WriteLine(i);
            }
        }
    }
    class Bingo : ISorteio {
        private int numBolas, aux = 0;
        private int[] bolasSorteadas, contadorBolas;

        public Bingo (int totalBola) {
            Iniciar(totalBola);
            this.numBolas = totalBola;
        }
        public void Iniciar(int numBolas) {
            this.bolasSorteadas = new int[numBolas];
            this.contadorBolas = new int[numBolas];
        }  
        public int Proximo() {
            int bolaEscolhida = 0;

            for (int i = 1; i > 0; i++) {
                Random x = new Random();
                int bola = x.Next(1, numBolas + 1);

                if (aux == numBolas) break;
                else if (contadorBolas[bola - 1] == 0) {
                    contadorBolas[bola - 1] = 1;
                    bolasSorteadas[aux] = bola;
                    bolaEscolhida = bola;
                    aux++;
                    break;
                }
                else if (bolasSorteadas[numBolas - 1] != 0) continue;
            }
            if (bolaEscolhida == 0) {
                Console.WriteLine("Muitos valores inseridos!");
                Environment.Exit(0);
            }
            return bolaEscolhida;
        }

        public int[] Sorteados(int check) {

            if (check != 0) {
                while (aux != numBolas) {
                    this.Proximo();
                }
            }
            return bolasSorteadas;
        }
    }
    class Mega : ISorteio {
        private int[] numerosSorteados, contadorBolas;
        int aux = 0;

        public Mega() {
            this.numerosSorteados = new int[6];
            this.contadorBolas = new int[60];
        }
        public int Proximo() {
            int bolaEscolhida = 0;

            for (int i = 1; i > 0; i++) {
                Random x = new Random();
                int bola = x.Next(1, 61);

                if (aux == 6) break;
                else if (contadorBolas[bola - 1] == 0) {
                    contadorBolas[bola - 1] = 1;
                    numerosSorteados[aux] = bola;
                    bolaEscolhida = bola;
                    aux++;
                    break;
                }
                else if (numerosSorteados[5] != 0) continue;
            }
            if (bolaEscolhida == 0) {
                Console.WriteLine("Muitos valores inseridos!");
                Environment.Exit(0);
            }
            return bolaEscolhida;
        }
        public int[] Sorteados(int check) {
            if (check != 0) {
                while (aux != 6) {
                    this.Proximo();
                }
            }
            return numerosSorteados;
        }
    }
    interface ISorteio {
        int Proximo();
        int[] Sorteados(int check);
    }
}

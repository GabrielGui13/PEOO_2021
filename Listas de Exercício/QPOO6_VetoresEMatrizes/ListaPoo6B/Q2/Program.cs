using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo x = new Bingo(20);
            Console.WriteLine(x.retornarValores());
        }
    }
    class Bingo {
        private int numBolas;
        private int[] numerosSorteados, arrayAuxiliar;
        private string mostrarSorteados = "[";
        public Bingo (int numBolas) {
            this.numBolas = numBolas;
            numerosSorteados = new int[numBolas];
            arrayAuxiliar = new int[numBolas];
        }
        public int proximo() {
            Random rand = new Random();
            int bolaSorteada = rand.Next(1, (numBolas + 1));

            return bolaSorteada;
        }
        public void registrarNumeros() {
            int aux = 0;
            for (int i = 1; i > 0; i++) {
                int retornoRand = proximo();
                if (arrayAuxiliar[retornoRand - 1] == 0) {
                    arrayAuxiliar[retornoRand - 1] = 1;
                    numerosSorteados[aux] = retornoRand;
                    aux++;
                }
                if (numerosSorteados[numBolas - 1] != 0) break;
            }
        }
        public int[] sorteados() {
            return this.numerosSorteados;
        } 
        public string retornarValores() {
            registrarNumeros();
            for (int i = 0; i < numerosSorteados.Length; i++) {
                if (i != numBolas - 1) mostrarSorteados += numerosSorteados[i] + ", ";
                else mostrarSorteados += numerosSorteados[i].ToString() + "]";
            }

            return mostrarSorteados;
        }
    }
}

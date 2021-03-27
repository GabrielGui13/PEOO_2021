using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bingo x = new Bingo(10);
            Console.WriteLine(x.retornarValores());
        }
    }
    class Bingo {
        private int numBolas;
        private int[] numerosSorteados;
        private string mostrarSorteados = "[";
        public Bingo (int numBolas) {
            this.numBolas = numBolas;
        }
        public int proximo() {
            Random x = new Random();
            int bolaSorteada = x.Next(1, (numBolas + 1));
            registrarNumeros();

            return bolaSorteada;
        }
        public void registrarNumeros() {
            for (int i = 0; i < numerosSorteados.Length; i++) {
                if (numerosSorteados.Contains(proximo())) continue;
                else numerosSorteados[i] = proximo();
            }
        }
        public int[] sorteados() {
            return this.numerosSorteados;
        } 
        public void retornarValores() {
            for (int i = 0; i < numerosSorteados.Length; i++) {
                if (i != numBolas - 1) mostrarSorteados += numerosSorteados[i] + ", ";
                else mostrarSorteados += numerosSorteados[i].ToString() + "]";
            }
        }
    }
}

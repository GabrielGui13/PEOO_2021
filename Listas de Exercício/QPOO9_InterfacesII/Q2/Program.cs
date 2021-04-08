using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            PA x = new PA(2, 5);
            Console.WriteLine(x.Proximo());
        }
    }
    class PA : ISequencia {
        private int primeiroElemento, razao, aux = 0;
        public PA (int p, int r) {
            this.primeiroElemento = p;
            this.razao = r;
        }
        public int Iniciar() {
            return primeiroElemento;
        }
        public int Proximo() {
            aux++;
            return primeiroElemento + razao * aux;
        }
    }
    class Fibonacci : ISequencia {
        private int primeiroElemento, razao, aux = 1;
        public Fibonacci () {
            this.primeiroElemento = 0;
            this.elemento = primeiroElemento;
        }
        public int Iniciar() {
            return primeiroElemento;
        }
        public int Proximo() {
            
        }
    }
    interface ISequencia {
        int Iniciar();
        int Proximo();
    }
}

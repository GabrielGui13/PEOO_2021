using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {   
            ISequencia x = new Fibonacci();
            ISequencia y = new PA(2, 2);

            for (int i = 0; i < 11; i++) {
                Console.WriteLine(x.Proximo());
            }
            for (int i = 0; i < 11; i++) {
                Console.WriteLine(y.Proximo());
            }
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
        public int primeiroElemento, razao, e1, e2, e3, aux = 0;
        public Fibonacci () {
            this.primeiroElemento = 0;
            this.e1 = 0;
            this.e2 = 1;
            this.razao = e1 + e2;
            this.e3 = razao;
        }
        public int Iniciar() {
            return primeiroElemento;
        }
        public int Proximo() {
            if (aux == 0) {
                aux++;
                return 0;
            }
            else if (aux == 1) {
                aux++;
                return 1;
            }
            this.e1 = this.e2;
            this.e2 = this.e3;
            this.e3 = e1 + e2;
            this.razao = e3;

            return e3;
        }
    }
    interface ISequencia {
        int Iniciar();
        int Proximo();
    }
}

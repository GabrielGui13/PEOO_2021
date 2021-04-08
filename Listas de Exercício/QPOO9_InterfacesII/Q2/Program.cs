using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci x = new Fibonacci();
            
        }
    }
    class PA : ISequencia {
        private int primeiroElemento, razao, aux = 1;
        public PA (int p, int r) {
            this.primeiroElemento = p;
            this.razao = r;
        }
        public int Iniciar() {
            return primeiroElemento;
        }
        public int Proximo() {
            return primeiroElemento + razao * aux;
            aux++;
        }
    }
    class Fibonacci : ISequencia {
        private int primeiroElemento, razao, aux = 1;
        public Fibonacci () {
            this.primeiroElemento = 0;
            this.elemento = primeiroElemento;
            this.razao = (elemento - 1) + (elemento - 2);
        }
        public int Iniciar() {
            return primeiroElemento;
        }
        public int Proximo() {
            if (elemento == 0) {
                return 0;
                this.elemento = 1;
            }
            else if (elemento == 1) {
                return 1;
                this.elemento = 2;
            }
            else {
                return novoElemento;
                elemento = novoElemento;
            }
        }
    }
    interface ISequencia {
        int Iniciar();
        int Proximo();
    }
}

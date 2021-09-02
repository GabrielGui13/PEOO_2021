using System;

namespace q11_apoo {
    class Interface {
        static void Main(string[] args) {
            int x;
            if (x < 10) {
                Conta c2 = new Conta();
                c2.Sacar();
            }
        }
    }
    class Conta {
        public void Sacar() {
            Console.WriteLine("Sacado");
        }
    }
}

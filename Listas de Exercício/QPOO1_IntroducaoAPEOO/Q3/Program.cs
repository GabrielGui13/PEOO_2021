using System;

namespace Q3
{
    class Program {
        static void Main(string[] args) {
            Viagem x = new Viagem();
            x.SetTempo(2,30);
            x.SetDistancia(200);
            Console.WriteLine(x.VelocidadeMedia() + "km/h");
        }
    }
    class Viagem {
        private double distancia;
        private double tempo;
        public void SetDistancia(double d) {
            if (d>0) distancia = d; 
        }
        public void SetTempo(int h, double m) {
            if(m > 0 && h > 0 ) tempo = h + (m/60);
        }
        public double VelocidadeMedia() {
            return distancia / tempo;
        }
    }
}

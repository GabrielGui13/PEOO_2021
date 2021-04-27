using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args) {
            Viagem x = new Viagem();
            Console.WriteLine("Qual foi a duracao da viagem? em HH:MM");
            string[] horario = Console.ReadLine().Split(':');
            double minutos,horas;
            minutos = double.Parse(horario[1]);
            horas = double.Parse(horario[0]);
            x.SetTempo(horas + (minutos/60));
            Console.WriteLine("Qual foi a distancia percorrida? em Km");
            x.SetDistancia(int.Parse(Console.ReadLine()));
            Console.WriteLine($"{x.VelocidadeMedia():.00}km/h");
        }
    }
    class Viagem {
        private double distancia,tempo;
        public void SetDistancia(double d)
        {
            if (d>0) distancia = d;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public void SetTempo(double t)
        {
            if(t>0) tempo = t;
        }
        public double GetTempo()
        {
            return tempo;
        }
        public double VelocidadeMedia()
        {
            return distancia/tempo;
        }

    }
}

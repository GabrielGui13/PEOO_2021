using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Frete x = new Frete(500,4);
            x.SetDistancia(400);
            x.SetPeso(10);
            Console.WriteLine(x.CalcFrete());
        }
    }
    class Frete
    {
        private double distancia,peso;
        public Frete(double d, double p)
        {
            if (d > 0) distancia = d;
            if (p > 0) peso = p;
        }
        public void SetDistancia (double d)
        {
            if(d > 0) distancia = d;
        }
        public double GetDistancia()
        {
            return distancia;
        }
        public void SetPeso(double p)
        {
            if(p > 0) peso = p;
        }
        public double GetPeso()
        {
            return peso;
        }
        public double CalcFrete()
        {
            //1 centavo para cada quilo por km
            return (distancia * peso) / 100;
        }
    }
}

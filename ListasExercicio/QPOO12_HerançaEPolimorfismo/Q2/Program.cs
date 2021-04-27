using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Frete x = new Frete(600, 5000);
            Console.WriteLine(x);
            FreteExpresso y = new FreteExpresso(300, 7000, 1000);
            Console.WriteLine(y);
        }
    }
    class Frete {
        protected double distancia, peso;
        public virtual decimal ValorFrete {
            get => Convert.ToDecimal(distancia * peso * 0.01);
        }
        public Frete (double d, double p) {
            this.distancia = d;
            this.peso = p;
        }
        public override string ToString(){
            return $"Distancia = {distancia} \nPeso = {peso} \nValor = {ValorFrete}\n";
        }
    }
    class FreteExpresso : Frete {
        private decimal seguro;
        public override decimal ValorFrete {
            get => base.ValorFrete * Convert.ToDecimal(2) + (seguro * Convert.ToDecimal(0.1));
        } 
        public FreteExpresso(double d, double p, decimal s) : base (d, p) {
            this.seguro = s;
        }
        public override string ToString(){
            return $"Distancia = {distancia} \nPeso = {peso} \nSeguro = {seguro} \nValor = {ValorFrete}\n";
        }
    }
}

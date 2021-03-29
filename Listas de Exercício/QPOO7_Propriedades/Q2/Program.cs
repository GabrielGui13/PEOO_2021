using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args) {
            Frete x = new Frete{Distancia = 585, Peso = 500};
            Console.WriteLine(x);
        }
    }
    class Frete {
        private double distancia, peso;
        public double Distancia {
            get {return distancia;}
            set {if (value > 0) distancia = value;}
        }
        public double Peso {
            get {return peso;}
            set {if (value > 0) peso = value;}
        }
        public double valorFrete {
            get {return peso / 100 * distancia;}
        }
        public override string ToString() {
            return $"Distancia = {distancia} \nPeso = {peso} \nPreço Kg/Km = R$0,01 \nValor = {valorFrete}";
        }
    }
}

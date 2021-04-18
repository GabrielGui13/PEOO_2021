using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo(3, 4);
            Console.WriteLine(x);
            Quadrado y = new Quadrado(10);
            Console.WriteLine(y);
            Retangulo z = new Quadrado(5);
            Console.WriteLine(z);
        }
    }
    class Retangulo {
        private double b, h;
        public Retangulo(double b, double h) {
            this.b = b;
            this.h = h;
        }
        public double Base {
            get => b;
        }
        public double Altura {
            get => h;
        }
        public double Area {
            get => b * h;
        }
        public double Diagonal {
            get => Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
        }
        public override string ToString()
        {
            return $"Base = {Base} \nAltura = {Altura} \nArea = {Area} \nDiagonal = {Diagonal}\n";
        }
    }
    class Quadrado : Retangulo {
        public Quadrado(double l) : base(l, l) {}
        public override string ToString()
        {
            return $"Base = {Base} \nAltura = {Altura} \nArea = {Area} \nDiagonal = {Diagonal:.00}\n";
        }
    }
}

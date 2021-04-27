using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo(10,20);
            x.SetAltura(3);
            x.SetBase(4);
            Console.WriteLine(x.CalcArea());
        }
    }
    class Retangulo
    {
        private double b,h;
        public Retangulo(double b, double h)
        {
            if(b > 0) this.b = b;
            if(h > 0) this.h = h;
        }
        public void SetBase(double b)
        {
            if(b > 0) this.b = b;
        }
        public double GetBase()
        {
            return b;
        }
        public void SetAltura(double h)
        {
            if(h > 0) this.h = h;
        }
        public double GetAltura()
        {
            return h;
        }
        public double CalcArea()
        {
            return b*h;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(b,2)+ Math.Pow(h,2));
        }
        public override string ToString()
        {
            return $"Base = {b}, Altura = {h}";
        }
    }
}

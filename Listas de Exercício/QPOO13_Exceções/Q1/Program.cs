using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Retangulo {
        private double b, h;
        public double Area {
            get {return b * h;}
        }
        public double Diagonal {
            get {return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2)); }
        }
        public void setBase(double b) {
            if (b > 0) this.b = b;
            else throw new ArgumentOutOfRangeException();
        }
        public double 
    }
}

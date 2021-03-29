using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo{Base = 40, Altura = 30};
            Console.WriteLine(x);
        }
    }
    class Retangulo {
        private double b, h;
        public double Base {
            get {return b;}
            set {if (value > 0) b = value;}
        }
        public double Altura {
            get {return h;}
            set {if (value > 0) h = value;}
        }
        public double Area {
            get {return (b * h) / 2;}
        }
        public double Diagonal {
            get {return Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));}
        }
        public override string ToString() => $"Base = {Base} \nAltura = {Altura} \nArea = {Area} \nDiagonal = {Diagonal}";
    }
}

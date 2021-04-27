using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();
            try {
                Console.WriteLine("Base");
                x.setBase(double.Parse(Console.ReadLine()));
                Console.WriteLine("Altura");
                x.setAltura(double.Parse(Console.ReadLine()));

                Console.WriteLine(x);
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Digite um numero acima de 0");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) {
                Console.WriteLine("Numero invalido");
                Console.WriteLine(e.Message);
            }
            catch (Exception) {
                Console.WriteLine("Ocorreu algum erro tente novamente");
            }
            finally {
                Console.WriteLine("Fim");
            }
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
            else throw new ArgumentOutOfRangeException("Numero negativo");
        }
        public double getBase() {
            return b;
        }
        public void setAltura(double h) {
            if (h > 0) this.h = h;
            else throw new ArgumentOutOfRangeException("Numero negativo");
        }
        public double getAltura() {
            return h;
        }
        public override string ToString()
        {
            return $"Base = {getBase()} \nAltura = {getAltura()} \nArea = {Area} \nDiagonal = {Diagonal:.00}";
        }
    }
}

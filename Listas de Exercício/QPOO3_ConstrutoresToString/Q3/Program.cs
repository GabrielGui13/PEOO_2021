using System;

namespace Q3
{
     class Program
    {
        static void Main(string[] args)
        {
            Conversor x = new Conversor(9);
            Console.WriteLine(x.Binario());
            Console.WriteLine(x.ToString());
        }
    }
    class Conversor
    {
        private int num;
        private string resultado;
        public Conversor(int num)
        {
            if(num>0) this.num = num;
        }
        public void SetNum(int num)
        {
            if(num>0) this.num = num;
        }
        public int GetNum()
        {
            return num;
        }
        public string Binario()
        {
            resultado = "";
            int aux = num;
            for(int i = 0;aux > 0;i++)
            {
                resultado = aux%2 + resultado;
                aux /= 2;
            }
            return resultado;
        }
        public override string ToString()
        {
            return $"Base decimal = {num}, Base binaria = {resultado}";
        }    
    }
}

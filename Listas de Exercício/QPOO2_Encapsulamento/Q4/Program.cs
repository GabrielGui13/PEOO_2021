using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco x = new Banco();
            x.SetNome("Gabriel");
            x.SetConta(895945);
            x.SetSaldo(3000);
            Console.WriteLine(x.GetSaldo());
            x.Deposito();
            Console.WriteLine(x.GetSaldo());
            x.Saque();
            Console.WriteLine(x.GetSaldo());
        }
    }
    class Banco
    {
        private string nome; 
        private double conta, saldo;
        public void SetNome(string n)
        {
            nome = n;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetConta(double n)
        {
            conta = n;
        }
        public double GetConta()
        {
            return conta;
        }
        public void SetSaldo(double s)
        {
            saldo = s;
        }
        public double GetSaldo()
        {
            return saldo;
        }
        public double Saque(double n)
        {
            if (n <= saldo && n >0) saldo -= n;
            return n;
        }
        public double Deposito(double n)
        {
            if (n > 0) saldo+=n;
            return n;
        }
    }
}

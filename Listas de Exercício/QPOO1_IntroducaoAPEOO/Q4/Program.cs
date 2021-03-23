using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x = new Conta();
            Console.WriteLine("Qual eh seu nome?");
            x.nome = Console.ReadLine();
            Console.WriteLine($"Ola {x.nome}. Qual eh sua conta?");
            x.conta = Console.ReadLine();
            x.SetDeposito(3000);
            Console.WriteLine($"Sua conta eh {x.conta}, certo? vc acaba de ganhar 3000 de presente");
            Console.WriteLine("Qual operacao deseja fazer?\n1-Sacar\n2-Depositar");
            int entrada = 0;
            while (entrada != 3 || entrada == 1 || entrada == 2)
            {
                entrada = int.Parse(Console.ReadLine());
                
                if(entrada == 1)
                {
                    Console.WriteLine("Quanto vc deseja sacar?");
                    double pombadeleite = double.Parse(Console.ReadLine());
                    x.SetSaque(pombadeleite);
                Console.WriteLine("");
                    Console.Write("Aguarde");
                    for (int i = 0; i <= 3; i++) {
                        System.Threading.Thread.Sleep(750);
                        if (i <= 2) Console.Write(".");
                        else Console.Write(" ");
                    }
                    Console.WriteLine ( $"vc sacou {pombadeleite} e agora tem {x.saldosaque} " );
                    Console.WriteLine("Qual operacao deseja fazer?\n1-Sacar\n2-Depositar\n3-Sair");
                }
                if(entrada == 2)
                {
                    Console.WriteLine("Quanto vc deseja depositar?");
                    double entdeposito = double.Parse(Console.ReadLine());
                    x.SetDeposito(entdeposito);
                    Console.WriteLine("");
                    Console.Write("Aguarde");
                    for (int i = 0; i <= 3; i++) {
                        System.Threading.Thread.Sleep(750);
                        if (i <= 2) Console.Write(".");
                        else Console.Write(" ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine ( $"vc depositou {entdeposito} e sua conta agora tem {x.saldodeposito} " );
                    Console.WriteLine("que operacao deseja fazer agora?\n1-Sacar\n2-Depositar\n3-Sair");
                }
            }

        }
    }
    
    class Conta
    {
        public string nome, conta;
        public double saldodeposito,saldo,saque,saldosaque,aux;
        
        public void SetDeposito(double d)
        {
            saldodeposito+=d;
            saldo = saldodeposito;
        }
        public void SetSaque(double s)
        {
            saldosaque = saldo;
            if(s <= saldo) 
            {
                saque = s;
                saldosaque -= s;
                saldodeposito -= s;
            }

        }
        public double Deposito()
        {
            return saldodeposito;
        }
        public double Saque()
        {
            return saque;
        }
        
    }
}

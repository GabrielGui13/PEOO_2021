using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia");
            Cinema.dia = Console.ReadLine().ToLower();

            Console.WriteLine("Digite a hora no formato HH:MM");
            string[] enthora = Console.ReadLine().Split(':');
                if (enthora[0] == "00") Cinema.hora = 24;
                else Cinema.hora = int.Parse(enthora[0]);
            Console.WriteLine("vc eh estudante? \n1-SIM | 2-NAO");
            int estudante = int.Parse(Console.ReadLine());
                if (estudante == 1) Cinema.meia = true; 
                else if (estudante == 2) Cinema.meia = false;

            Console.WriteLine($"O valor sera de R$:{Cinema.valor():.00}");
        }
    }
    class Cinema
    {
        public static int preco,hora;
        public static bool meia;
        public static string dia;
        public static int valor()
        {
            switch(dia){
                case "segunda": 
                case "terca":
                case "quinta": 
                    if(hora >= 17 && hora <= 24) preco = 24;
                    else preco = 16; break;
                case "quarta": preco = 8;break;
                case "sexta":
                case "sabado":
                case "domingo":
                    if(hora >= 17 && hora <= 24) preco = 30;
                    else preco = 20; break;
            }
            if(meia == true && dia != "quarta") preco /=2;
            
            return preco;
        }

    }
}

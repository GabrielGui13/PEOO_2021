using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema x = new Cinema();
            x.SetDia("quinta");
            x.SetHora("18:30");
            Console.WriteLine(x.GetDia());
            Console.WriteLine(x.GetHora());
            Console.WriteLine(x.Preco());
            Console.WriteLine(x.PrecoMeia());
        }
    }
    class Cinema
    {
        private int hora,preco,dia,minuto;
        public void SetDia(string s)
        {
            string[] dias = { "domingo", "segunda", "terca", "quarta", "quinta", "sexta", "sabado"};
            for(int i = 0; i< dias.Length; i++)
            {
                if(s == dias[i]) dia = 1 + Array.IndexOf(dias, s);
            }
        }
        public int GetDia()
        {
            return dia;
        } 
        public void SetHora(string s)
        {

            string[] aux = s.Split(':');
            minuto = int.Parse(aux[1]);
            if (minuto > 0) hora++;
            hora += int.Parse(aux[0]);
            if (hora == 0) hora = 24;
        }
        public int GetHora()
        {
            return hora;
        }
        public double Preco()
        {
            switch(dia)
            {
                case 2:
                case 3:
                case 5:
                    if (hora >=17 && hora <=24 ) preco = 24;
                    else preco = 16; 
                break;
                case 4: preco=8;
                break;
                case 1:
                case 6:
                case 7:
                    if(hora>= 17 && hora <= 24) preco = 30;
                    else preco = 20;
                break;
            }
            return preco;
        }
        public double PrecoMeia()
        {
            if(dia != 4) preco /= 2;
            return preco;
        }

    }
}

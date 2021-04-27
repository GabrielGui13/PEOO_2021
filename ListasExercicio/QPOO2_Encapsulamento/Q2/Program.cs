using System;

namespace Q2
{
   class Program
    {
        static void Main(string[] args)
        {
            Disciplina x = new Disciplina();
            Console.WriteLine("Bem vindo ao calculador de media");
            Console.WriteLine("Vamos comecar, qual a disciplina que vc deseja saber a nota?");
            x.SetNome(Console.ReadLine());
            Console.WriteLine($"Certo, vc quer saber a nota de {x.GetNome()}, digite suas notas");
            Console.WriteLine("Nota1?");
            x.SetNota1(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nota2?");
            x.SetNota2(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nota3?");
            x.SetNota3(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nota4?");
            x.SetNota4(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Otimo, notas salvas.");
            Console.Write("Aguarde");
                        for (int i = 0; i <= 3; i++) {
                            System.Threading.Thread.Sleep(750);
                            if (i <= 2) Console.Write(".");
                            else Console.Write(" ");
                        }
                    Console.WriteLine("");
            if(x.CalcMediaParcial() >= 60) Console.WriteLine($"PARABENS!! SUA MEDIA FOI {x.CalcMediaParcial()}");
            else 
            {
                Console.WriteLine($"vc ficou de recuperacao, e sua media foi {x.CalcMediaParcial()} =(");
                Console.WriteLine("Vamos calcular sua media final, digite sua nota final");
                x.SetNotaFinal(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Otimo, nota salva.");
                Console.Write("Aguarde");
                    for (int i = 0; i <= 3; i++) {
                        System.Threading.Thread.Sleep(750);
                        if (i <= 2) Console.Write(".");
                        else Console.Write(" ");
                    }
                    Console.WriteLine("");
                if (x.CalcMediaFinal() >= 60)Console.WriteLine($"EBA!!! vc passou de ano. Sua nota final foi {x.CalcMediaFinal()}");
                else Console.WriteLine($"sua nota foi{x.CalcMediaFinal()}. Que pena, vc nao conseguiu esse ano. quem sabe na proxima? Nao desista!");

            }

        }
    }
    class Disciplina
    {
        private int nota1, nota2, nota3, nota4, notaFinal, mediaParcial, mediaFinal;
        private string nome;

        public void SetNome(string s)
        {
            this.nome = s;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNota1(int n)
        {
            if(n >= 0) nota1 = n;
        }
        public int GetNota1()
        {
            return nota1;
        }

        public void SetNota2(int n)
        {
            if(n >= 0) nota2 = n;
        }
        public int GetNota2()
        {
            return nota2;
        }

        public void SetNota3(int n)
        {
            if(n >= 0) nota3 = n;
        }
        public int GetNota3()
        {
            return nota3;
        }

        public void SetNota4(int n)
        {
            if(n >= 0) nota4 = n;
        }
        public int GetNota4()
        {
            return nota4;
        }
        public void SetNotaFinal(int n)
        {
            if(n>=0) notaFinal = n;
        }
        public int GetNotaFinal()
        {
           return notaFinal;
        }
        public int CalcMediaParcial()
        {
            mediaParcial =(nota1*2 + nota2*2 + nota3 * 3 + nota4*3)/10; 
            return mediaParcial; 
        }
        public int CalcMediaFinal()
        {
            mediaFinal = (mediaParcial + notaFinal) / 2;
            return mediaFinal;
        }
    }
}

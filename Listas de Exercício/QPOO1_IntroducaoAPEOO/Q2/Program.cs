using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args) {
            Disciplina x;
            x = new Disciplina();
            x.nota1 = 100;
            x.nota2 = 55;
            x.nota3 = 56;
            x.nota4 = 58;
            x.notafinal= 80;
            x.nome = "POO";
            Console.Write($"Na disciplina {x.nome}, ");
            Console.Write(x.MediaParcial());
            Console.Write(x.MediaFinal());

        }
    }
    class Disciplina
    {
        public int nota1,nota2,nota3,nota4,notafinal,media;
        public string nome;
        public string MediaParcial() {
            media = ((nota1*2)+ (nota2*2)+ (nota3 * 3)+ (nota4*3))/10; 
            if (media <= 60) return ($"sua nota foi {media} e vc precisa de {120 - media} na prova final ");
            else return ($"vc passou por media com a nota {media}");   
        }
        
        public string MediaFinal() {
            if (media >= 60) return("e n precisa de prova final");
            else return ($" \n Sua media final foi {(media + notafinal) / 2}") ;
        }
    }
}

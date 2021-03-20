using System;

namespace batalha
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Metodos x = new Metodos();
            Lutador champ1 = new Lutador("Rafael", 107, 17, 5, 0);
            x.armazenarLutador(champ1);
            Lutador champ2 = new Lutador("Edson", 148, 16, 4, 1);
            x.armazenarLutador(champ2);
            Lutador champ3 = new Lutador("Fonti", 61, 17, 3 ,2);
            x.armazenarLutador(champ3);
            Lutador champ4 = new Lutador("Bruce", 65, 17, 0, 5);
            x.armazenarLutador(champ4);
            x.definirBatalha();
        }
    }
    class Metodos {
        public Lutador[] lutadores = new Lutador[4];
        private int aux = 0;
        public void armazenarLutador (Lutador y) {
            lutadores[aux] = y;
            aux++;
        }
        public void definirBatalha() {
            int acl1 = 0;
            int acl2 = 0;
            for (int i = 1; i != 0; i++) {
                Random rnd1 = new Random();
                int l1 = rnd1.Next(0, 4);
                acl1 = l1;

                Random rnd2 = new Random();
                int l2 = rnd2.Next(0, 4);
                acl2 = l2;

                if (l1 == l2) continue;
                else {
                    Console.WriteLine($"{l1} e {l2}");
                    break;
                }
            }
            Console.WriteLine("A batalha está definida!");
            Console.WriteLine($"O campeão {lutadores[acl1].getNome()}! de {lutadores[acl1].getPeso()}kg");
            Console.WriteLine($"Contra o poderoso {lutadores[acl2].getNome()}! de {lutadores[acl2].getPeso()}kg");
            
            Random win = new Random();
            int setWinner = win.Next(1, 3);
            //if (setWinner == 0) Console.WriteLine($"E o grande vencedor é {lutadores[acl1].getNome()}!!");
            //else if (setWinner == 1) Console.WriteLine($"E o grande vencedor é {lutadores[acl2].getNome()}!!");
            Console.WriteLine(setWinner);
        }
    }
    class Lutador {
        private string nome;
        private double peso;
        private string categoria;
        private int idade;
        private int vitoria = 0;
        private int derrota = 0;
        public Lutador (string xnome, double xpeso, int xidade, int xvitoria, int xderrota) {
            this.nome = xnome;
            this.setPeso(xpeso);
            this.idade = xidade;
            this.vitoria = xvitoria;
            this.derrota = xderrota;
        }

        public override string ToString() {
            return $"{nome} {peso} {categoria} {idade} {vitoria} {derrota}";
        }

        public void setNome (string nome) {
            this.nome = nome;
        }
        public string getNome() {
            return nome;
        }
        public void setPeso (double peso) {
            this.peso = peso;
            setCategoria();
        }
        public double getPeso() {
            return peso;
        }
        public void setCategoria () {
            if (this.peso >= 100) this.categoria = "Peso pesado";
            else if (this.peso >= 80 && this.peso < 100) this.categoria = "Peso medio";
            else if (this.peso >= 60 && this.peso < 80) this.categoria = "Peso leve";
            else this.categoria = "Peso inválido";
        }
        public string getCategoria() {
            return this.categoria;
        }
        public void setIdade (int idade) {
            this.idade = idade;
        }
        public string getIdade() {
            return idade.ToString();
        }
        public void setVitoria (int vitoria) {
            this.vitoria += vitoria;
        }
        public int getVitoria() {
            return vitoria;
        }
        public void setDerrota (int derrota) {
            this.derrota += derrota;
        }
        public int getDerrota() {
            return derrota;
        }
    }
}

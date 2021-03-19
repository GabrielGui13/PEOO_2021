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
            for (int i = 0; i > 0; i++) {
                Random rnd1 = new Random();
                int l1 = rnd1.Next(0, 3);

                Random rnd2 = new Random();
                int l2 = rnd2.Next(0, 3);

                if (l1 != l2) {
                    for (int z = 0; z > 0; z++) {
                        if (l1 != l2) {
                            if (lutadores[l1].getCategoria() == lutadores[l2].getCategoria()) {
                                Console.WriteLine($"E agora uma batalha de {lutadores[l1].getCategoria()}");
                                Random setWinner = new Random();
                                int win = setWinner.Next(1, 2);

                                if(win == 1) Console.WriteLine($"Parabéns {lutadores[l1].getNome()}, você ganhou!");
                                if(win == 2) Console.WriteLine($"Parabéns {lutadores[l2].getNome()}, você ganhou!");
                                break;
                            }
                        }
                        continue;
                    }
                }
                continue;
            }
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

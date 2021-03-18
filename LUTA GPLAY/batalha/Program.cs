using System;

namespace batalha
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Metodos x = new Metodos();
            Lutador champ1 = new Lutador("Rafael", 104, 17);
            x.armazenarLutador(champ1);
            Lutador champ2 = new Lutador("Edson", 148, 16);
            x.armazenarLutador(champ2);
            Lutador champ3 = new Lutador("Fonti", 61, 17);
            x.armazenarLutador(champ3);
            Lutador champ4 = new Lutador("Bruce", 65, 17);
            x.armazenarLutador(champ4);
            Console.WriteLine(x.lutadores[0]);
        }
    }
    class Metodos {
        public Lutador[] lutadores = new Lutador[4];
        private int aux = 0;
        public void armazenarLutador (Lutador y) {
            lutadores[aux] = y;
            aux++;
        }
        
    }
    class Lutador {
        private string nome;
        private double peso;
        private string categoria;
        private int idade;
        private int vitoria;
        private int derrota;
        public Lutador (string xnome, double xpeso, int xidade) {
            nome = xnome;
            peso = xpeso;
            idade = xidade;
        }

        public void setNome (string nome) {
            this.nome = nome;
        }
        public string getNome() {
            return nome;
        }
        public void setPeso (double peso) {
            this.peso = peso;
        }
        public string getPeso() {
            return peso.ToString();
        }
        public void setCategoria () {
            if (peso > 100) this.categoria = "Peso pesado";
            if (peso > 80 && peso < 100) this.categoria = "Peso medio";
            if (peso > 60 && peso < 80) this.categoria = "Peso leve";
        }
        public string getCategoria() {
            return categoria;
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

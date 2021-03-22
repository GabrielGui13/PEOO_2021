using System;

namespace batalha2
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Lutador champ1 = new Lutador("Rafael", 71, 17, 5, 0);
            champ1.apresentarLutador();
            Lutador champ2 = new Lutador("Edson", 148, 16, 4, 1);
            champ2.apresentarLutador();
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
            nome = xnome;
            peso = xpeso;
            idade = xidade;
            vitoria = xvitoria;
            derrota = xderrota;
        }
        public void apresentarLutador() {
            Console.WriteLine($"Conheça o lutador {getNome()}");
            Console.WriteLine($"De {getIdade()} anos");
            Console.WriteLine($"Com seus {getPeso()}kg");
            Console.WriteLine($"É o líder da categoria {getCategoria()}");
            Console.WriteLine($"Hoje com {getVitoria()} vitória(s)");
            Console.WriteLine($"E {getDerrota()} derrota(s)");
            Console.WriteLine("");
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
        public double getPeso() {
            return peso;
        }
        private void setCategoria () {
            if (this.peso > 100) this.categoria = "Peso pesado";
            else if (this.peso > 80) this.categoria = "Peso medio";
            else if (this.peso > 60) this.categoria = "Peso leve";
            else this.categoria = "Peso Inválido";
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

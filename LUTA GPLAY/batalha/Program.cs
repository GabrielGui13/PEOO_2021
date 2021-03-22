using System;

namespace batalha
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Metodos x = new Metodos();
            Lutador champ1 = new Lutador("Gabriel", 62, 17, 5, 0);
            x.armazenarLutador(champ1);
            Lutador champ2 = new Lutador("Edson", 77, 16, 4, 1);
            x.armazenarLutador(champ2);
            Lutador champ3 = new Lutador("Alvin", 64, 17, 3 ,2);
            x.armazenarLutador(champ3);
            Lutador champ4 = new Lutador("Bruce", 57, 17, 0, 5);
            x.armazenarLutador(champ4);
            x.definirBatalha();
            x.lutar();
        }
    }
    class Metodos {
        public Lutador[] lutadores = new Lutador[4];
        private int aux = 0;
        private Lutador desafiante;
        private Lutador desafiado;
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
                this.desafiante = lutadores[l1];

                Random rnd2 = new Random();
                int l2 = rnd2.Next(0, 4);
                acl2 = l2;
                this.desafiado = lutadores[l2];

                if (l1 == l2) continue;
                else {
                    break;
                }
            }
            Console.WriteLine("A batalha está definida!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"O campeão {lutadores[acl1].getNome()}! de {lutadores[acl1].getPeso()}kg");
            Console.WriteLine($"Contra o poderoso {lutadores[acl2].getNome()}! de {lutadores[acl2].getPeso()}kg");
        }
        public void lutar() {
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine($"Começa agora a batalha entre o {desafiante.getNome()} e o {desafiado.getNome()}");
            Console.WriteLine("####################");

            int vidaDesafiante = 100;
            int vidaDesafiado = 100;
            int turno = 1;

            int aux = 0;
            while (aux != 1) {
                Random gerarAtaque1 = new Random();
                int ataque1 = gerarAtaque1.Next(1, 11);

                Random gerarAtaque2 = new Random();
                int ataque2 = gerarAtaque2.Next(1, 11);

                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("");
                Console.WriteLine("#################");
                Console.WriteLine($"Turno {turno}!");

                System.Threading.Thread.Sleep(1500);

                switch (ataque1) { //ataques desafiante
                    case 1: vidaDesafiado -= 5; Console.WriteLine($"E o {desafiante.getNome()} derruba o {desafiado.getNome()}!"); break;
                    case 2: vidaDesafiado -= 5; Console.WriteLine($"{desafiante.getNome()} dá uma rasteira segura no {desafiado.getNome()}!"); break;
                    case 3: vidaDesafiado -= 5; Console.WriteLine($"{desafiante.getNome()} dá um chute na costela do {desafiado.getNome()}!"); break;
                    case 4: vidaDesafiado -= 10; Console.WriteLine($"Um soco de direita do {desafiante.getNome()} no {desafiado.getNome()}!"); break;
                    case 5: vidaDesafiado -= 10; vidaDesafiante -= 2; if(desafiante.getNome() == "Edson") {vidaDesafiado -= 100; vidaDesafiante += 2; Console.WriteLine($"Nunca vi uma cabeçada como essa! Que cabeçada o {desafiante.getNome()} deu no {desafiado.getNome()}! Já era!");} else Console.WriteLine($"Uau! Que cabeçada o {desafiante.getNome()} deu no {desafiado.getNome()}!"); break;
                    case 6: vidaDesafiado -= 10; Console.WriteLine($"Arremesso lateral do {desafiante.getNome()} no {desafiado.getNome()}!"); break;
                    case 7: vidaDesafiado -= 15; Console.WriteLine($"E {desafiante.getNome()} dá uma voadora na cara do {desafiado.getNome()}!"); break;
                    case 8: vidaDesafiado -= 15; Console.WriteLine($"{desafiante.getNome()} joga {desafiado.getNome()} pra cima!"); break;
                    case 9: vidaDesafiado -= 15; Console.WriteLine($"O {desafiante.getNome()} da uma paulada no {desafiado.getNome()}!"); break;
                    case 10: vidaDesafiado -= 35; if(desafiante.getPeso() > desafiado.getPeso()) vidaDesafiado -= 5; Console.WriteLine($"E o {desafiante.getNome()} acerta um ataque crítico no {desafiado.getNome()}!"); break;
                }

                System.Threading.Thread.Sleep(1500);

                switch (ataque2) { //ataques desafiado
                    case 1: vidaDesafiante -= 5; Console.WriteLine($"E o {desafiado.getNome()} derruba o {desafiante.getNome()}!"); break;
                    case 2: vidaDesafiante -= 5; Console.WriteLine($"{desafiado.getNome()} dá uma rasteira segura no {desafiante.getNome()}!"); break;
                    case 3: vidaDesafiante -= 5; Console.WriteLine($"{desafiado.getNome()} dá um chute na costela do {desafiante.getNome()}!"); break;
                    case 4: vidaDesafiante -= 10; Console.WriteLine($"Soco de direita do {desafiado.getNome()} no {desafiante.getNome()}!"); break;
                    case 5: vidaDesafiante -= 10; vidaDesafiado -= 2; if(desafiado.getNome() == "Edson") {vidaDesafiante -= 100; vidaDesafiado += 2;Console.WriteLine($"Nunca vi uma cabeçada como essa! Que cabeçada o {desafiado.getNome()} deu no {desafiante.getNome()}! Já era!");} else Console.WriteLine($"Uau! Que cabeçada o {desafiado.getNome()} deu no {desafiante.getNome()}!"); break;
                    case 6: vidaDesafiante -= 10; Console.WriteLine($"Arremesso lateral do {desafiado.getNome()} no {desafiante.getNome()}!"); break;
                    case 7: vidaDesafiante -= 15; Console.WriteLine($"E {desafiado.getNome()} dá uma voadora na cara do {desafiante.getNome()}!"); break;
                    case 8: vidaDesafiante -= 15; Console.WriteLine($"{desafiado.getNome()} joga {desafiante.getNome()} pra cima!"); break;
                    case 9: vidaDesafiante -= 15; Console.WriteLine($"O {desafiado.getNome()} da uma paulada no {desafiante.getNome()}!"); break;
                    case 10: vidaDesafiante -= 35; if(desafiado.getPeso() > desafiante.getPeso()) vidaDesafiado -= 5; Console.WriteLine($"E o {desafiado.getNome()} acerta um ataque crítico no {desafiante.getNome()}!"); break;
                }
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(1500);

                if (vidaDesafiado <= 0) { //vitoria desafiante
                    Console.WriteLine($"Acabou a luta em {turno} turnos! Vitória do {desafiante.getNome()}!");
                    Console.WriteLine($"{desafiante.getNome()} = {vidaDesafiante} de vida");
                    Console.WriteLine($"{desafiado.getNome()} = 0 de vida");
                    break;
                }
                else if (vidaDesafiante <= 0) { //vitoria desafiado
                    Console.WriteLine($"Acabou a luta em {turno} turnos! Vitória do {desafiado.getNome()}!");
                    Console.WriteLine($"{desafiado.getNome()} = {vidaDesafiado} de vida");
                    Console.WriteLine($"{desafiante.getNome()} = 0 de vida");
                    break;
                }
                else {
                    Console.WriteLine($"{desafiante.getNome()} = {vidaDesafiante} de vida");
                    Console.WriteLine($"{desafiado.getNome()} = {vidaDesafiado} de vida");
                    turno++;
                    System.Threading.Thread.Sleep(1500);
                    continue;
                }
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

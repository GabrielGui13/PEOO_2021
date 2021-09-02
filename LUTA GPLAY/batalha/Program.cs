using System;

namespace batalha
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Ringue x = new Ringue();
            Lutador champ1 = new Lutador("Rafael", 109, 18, 0, 0);
            x.armazenarLutador(champ1);
            Lutador champ2 = new Lutador("Edson", 77, 17, 0, 0);
            x.armazenarLutador(champ2);
            Lutador champ3 = new Lutador("Bruce", 60, 18, 0 ,0);
            x.armazenarLutador(champ3);
            Lutador champ4 = new Lutador("Fonti", 60, 17, 0, 0);
            x.armazenarLutador(champ4);
            x.definirBatalha();
            x.lutar();
        }
    }
    class Ringue {
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
                int l1 = rnd1.Next(0, lutadores.Length);
                acl1 = l1;
                this.desafiante = lutadores[l1];

                Random rnd2 = new Random();
                int l2 = rnd2.Next(0, lutadores.Length);
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
                int ataque1 = gerarAtaque1.Next(1, 13);

                Random gerarAtaque2 = new Random();
                int ataque2 = gerarAtaque2.Next(1, 13);

                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("");
                Console.WriteLine("#################");
                Console.WriteLine($"Turno {turno}!");

                System.Threading.Thread.Sleep(1500);

                switch (ataque1) { //ataques desafiante
                    case 1: vidaDesafiado -= 5; Console.WriteLine($"{desafiante.getNome()} derruba {desafiado.getNome()}!"); break;
                    case 2: vidaDesafiado -= 5; Console.WriteLine($"{desafiante.getNome()} dá uma rasteira segura em {desafiado.getNome()}!"); break;
                    case 3: vidaDesafiado -= 5; Console.WriteLine($"{desafiante.getNome()} dá um chute na costela de {desafiado.getNome()}!"); break;
                    case 4: vidaDesafiado -= 10; if(desafiante.getNome() == "Fonti"){Console.WriteLine($"E Fonti da uma cotocada no cu de {desafiado.getNome()}! Essa foi feia!"); vidaDesafiado -= 100;} else Console.WriteLine($"Um soco de direita de {desafiante.getNome()} em {desafiado.getNome()}!"); break;
                    case 5: vidaDesafiado -= 10; vidaDesafiante -= 2; if(desafiante.getNome() == "Edson") {vidaDesafiado -= 100; vidaDesafiante += 2; Console.WriteLine($"Nunca vi uma cabeçada como essa! Que cabeçada {desafiante.getNome()} deu em {desafiado.getNome()}! Já era!");} else Console.WriteLine($"Uau! Que cabeçada {desafiante.getNome()} deu em {desafiado.getNome()}!"); break;
                    case 6: vidaDesafiado -= 10; Console.WriteLine($"Arremesso lateral de {desafiante.getNome()} em {desafiado.getNome()}!"); break;
                    case 7: vidaDesafiado -= 15; Console.WriteLine($"E {desafiante.getNome()} dá uma voadora na cara de {desafiado.getNome()}!"); break;
                    case 8: vidaDesafiado -= 15; Console.WriteLine($"{desafiante.getNome()} joga {desafiado.getNome()} pra cima!"); break;
                    case 9: vidaDesafiado -= 15; if(desafiante.getNome() == "Rafael"){Console.WriteLine($"Ui! Rafael deu uma dura em {desafiado.getNome()}!"); vidaDesafiado -= 100;} else Console.WriteLine($"{desafiante.getNome()} da uma paulada em {desafiado.getNome()}!"); break;
                    case 10: vidaDesafiado -= 35; if(desafiante.getPeso() > desafiado.getPeso()) vidaDesafiado -= 5; Console.WriteLine($"E {desafiante.getNome()} acerta um ataque crítico em {desafiado.getNome()}!"); break;
                    case 11: Console.WriteLine($"E {desafiante.getNome()} erra o ataque!"); break;
                    case 12: Console.WriteLine($"Passou direto! {desafiante.getNome()} erra o ataque!"); break;
                }

                System.Threading.Thread.Sleep(1500);

                switch (ataque2) { //ataques desafiado
                    case 1: vidaDesafiante -= 5; Console.WriteLine($"E {desafiado.getNome()} derruba {desafiante.getNome()}!"); break;
                    case 2: vidaDesafiante -= 5; Console.WriteLine($"{desafiado.getNome()} dá uma rasteira segura em {desafiante.getNome()}!"); break;
                    case 3: vidaDesafiante -= 5; Console.WriteLine($"{desafiado.getNome()} dá um chute na costela de {desafiante.getNome()}!"); break;
                    case 4: vidaDesafiante -= 10; if(desafiado.getNome() == "Fonti"){Console.WriteLine($"E Fonti da uma cotocada no cu de {desafiante.getNome()}! Essa foi feia!"); vidaDesafiante -= 100;} else Console.WriteLine($"Um soco de direita de {desafiado.getNome()} em {desafiante.getNome()}!"); break;
                    case 5: vidaDesafiante -= 10; vidaDesafiado -= 2; if(desafiado.getNome() == "Edson") {vidaDesafiante -= 100; vidaDesafiado += 2;Console.WriteLine($"Nunca vi uma cabeçada como essa! Que cabeçada {desafiado.getNome()} deu em {desafiante.getNome()}! Já era!");} else Console.WriteLine($"Uau! Que cabeçada {desafiado.getNome()} deu em {desafiante.getNome()}!"); break;
                    case 6: vidaDesafiante -= 10; Console.WriteLine($"Arremesso lateral de {desafiado.getNome()} em {desafiante.getNome()}!"); break;
                    case 7: vidaDesafiante -= 15; Console.WriteLine($"E {desafiado.getNome()} dá uma voadora na cara de {desafiante.getNome()}!"); break;
                    case 8: vidaDesafiante -= 15; Console.WriteLine($"{desafiado.getNome()} joga {desafiante.getNome()} pra cima!"); break;
                    case 9: vidaDesafiante -= 15; if(desafiado.getNome() == "Rafael"){Console.WriteLine($"Ui! Rafael deu uma dura em {desafiante.getNome()}!"); vidaDesafiante -= 100;} else Console.WriteLine($"{desafiado.getNome()} da uma paulada em {desafiante.getNome()}!"); break;
                    case 10: vidaDesafiante -= 35; if(desafiado.getPeso() > desafiante.getPeso()) vidaDesafiante -= 5; Console.WriteLine($"E {desafiado.getNome()} acerta um ataque crítico em {desafiante.getNome()}!"); break;
                    case 11: Console.WriteLine($"E {desafiado.getNome()} erra o ataque!"); break;
                    case 12: Console.WriteLine($"Passou direto! {desafiado.getNome()} erra o ataque!"); break;
                }
                Console.WriteLine(" ");
                System.Threading.Thread.Sleep(1500);
                
                if (vidaDesafiado <= 0 && vidaDesafiante <= 0) {
                    Console.WriteLine($"Acabou a luta em {turno} turnos! Empate!");
                    Console.WriteLine($"{desafiado.getNome()} = 0 de vida");
                    Console.WriteLine($"{desafiante.getNome()} = 0 de vida");
                    break;
                }
                else if (vidaDesafiado <= 0) { //vitoria desafiante
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

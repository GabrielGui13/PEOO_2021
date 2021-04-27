using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa x = new Empresa();
            Cliente c1 = new Cliente("Gabriel", "097.819.644-99", 1100);
            x.inserir(c1);
            Cliente c2 = new Cliente("Rafael", "098.819.644-99", 700);
            x.inserir(c2);
            Cliente c3 = new Cliente("Cliver", "099.819.644-99", 500);
            x.inserir(c3);
            Cliente c4 = new Cliente("Bruce", "100.819.644-99", 900);
            x.inserir(c4);

            c1.setSocio(c2);
            c3.setSocio(c4);

            c1.setSocio(c3);
            Console.WriteLine(c2);
        }
    }
    class Empresa {
        public Cliente[] clientes;
        private int aux = 0;
        public Empresa() {
            this.clientes = new Cliente[0];
        }
        public void inserir(Cliente c) {
            if (aux == clientes.Length) Array.Resize(ref clientes, aux + 1);
            clientes[aux] = c;
            aux++;
        }
        public Cliente[] listar() {
            return clientes;
        }
    }
    class Cliente {
        private string nome, cpf;
        private decimal limite, limiteInicial;
        private Cliente socio;
        public Cliente(string nome, string cpf, decimal limite) {
            this.nome = nome;
            this.cpf = cpf;
            this.limiteInicial = limite;
            this.limite = limite;
        }
        public void acabarSociedade() {
            this.socio = null;
            this.limite = limiteInicial;
        }
        public void setSocio(Cliente c) {
            decimal limiteSociedade = c.getLimiteInicial() + this.getLimiteInicial();

            if (c.getSocio() == null && this.getSocio() == null) {
                this.socio = c;
                c.socio = this;
                this.setLimite(limiteSociedade);
                c.setLimite(limiteSociedade);
            }
           else {
                if (c.socio != null) c.socio.acabarSociedade(); //acaba a sociedade do socio do cliente (caso tenha)
                socio.acabarSociedade(); //acaba a sociedade do meu ex socio
                acabarSociedade(); //acaba a minha sociedade
                c.acabarSociedade(); //acaba a sociedade do cliente

                //todos estão padrão
                this.socio = c;
                c.socio = this;
                this.setLimite(limiteSociedade);
                c.setLimite(limiteSociedade);
            }
        }
        public void setLimite(decimal limite) {
            this.limite = limite;
        }
        public decimal getLimite() {
            return limite;
        }
        public decimal getLimiteInicial() {
            return limiteInicial;
        }
        public string getNome() {
            return nome;
        }
        public Cliente getSocio() {
            return socio;
        }
        public override string ToString() {
            return $"Nome = {nome} \nCPF = {cpf} \nLimite = {limite} \nSocio = {(getSocio() == null ? "Não tem sócio" : socio.getNome())}";
        }
    }
}

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
            Console.WriteLine(c3);
            //Console.WriteLine(c1);
            //Console.WriteLine(c4);
            
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
        private Cliente[] listaClientes;
        private decimal limite;
        private Cliente socio;
        public Cliente(string nome, string cpf, decimal limite) {
            this.nome = nome;
            this.cpf = cpf;
            this.limite = limite;
        }
        public void definirSociedade(Cliente c) {
            this.socio = c;
        }
        public void setSocio(Cliente c) {
            if (socio == null && c.getSocio() == null) {
                Empresa x = new Empresa();
                this.listaClientes = x.listar();

                setLimite(c.getLimite());
                c.setLimite(limite - c.getLimite()); //definiu os limites

                if (getLimite() == c.getLimite()) definirSociedade(c);
            }

            for (int i = 0; i < listaClientes.Length; i++) {
                if(listaClientes[i].getCPF() == getCPF()) {
                    c.definirSociedade(listaClientes[i]);
                }
            }
        }
        public void setLimite(decimal limite) {
            this.limite += limite;
        }
        public decimal getLimite() {
            return limite;
        }
        public string getNome() {
            return nome;
        }
        private string getCPF() {
            return cpf;
        }
        private Cliente getSocio() {
            return socio;
        }
        public override string ToString() {
            return $"Nome = {nome} \nCPF = {cpf} \nLimite = {limite} \nSocio = {(socio.getNome() == null ? "" : socio.getNome())}";
        }
    }
}

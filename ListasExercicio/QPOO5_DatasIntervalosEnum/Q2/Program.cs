using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataValidade = DateTime.Parse("2021-12-31");
            ValeCompras x1 = new ValeCompras(dataValidade, Convert.ToDecimal(399.90));
            Produto x2 = new Produto("Ovo de Pascoa", Convert.ToDecimal(79.90));

            DateTime diaPremio = DateTime.Now;
            Premio client = new Premio("Gabriel", diaPremio);
            client.setPremio(x2);
            Console.WriteLine(client);
        }
    }
    class Premio {
        private string cliente;
        private DateTime data;
        private object premio;
        public Premio(string c, DateTime d) {
            this.cliente = c;
            this.data = d;
        }
        public void setPremio(object p) {
            this.premio = p;
        }
        public object getPremio () {
            return premio;
        }
        public override string ToString()
        {
            return $" Cliente = {cliente} \n Data = {data} \n Premio = {premio}";
        }
    }
    class ValeCompras {
        private DateTime dataValidade;
        private decimal valor;
        public ValeCompras (DateTime d, decimal v) {
            this.dataValidade = d;
            this.valor = v;
        }
        public override string ToString()
        {
            return $"{dataValidade} {valor}";
        }
    }
    class Produto {
        private string descricao;
        private decimal valor;
        public Produto (string d, decimal v) {
            this.descricao = d;
            this.valor = v;
        }
        public override string ToString()
        {
            return $"{descricao} {valor}";
        }
    }
}

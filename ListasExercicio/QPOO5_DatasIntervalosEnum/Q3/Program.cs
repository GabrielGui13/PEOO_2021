using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto contaLuz = new Boleto("7010952390", new DateTime(2021, 03, 06), new DateTime(2021, 03, 13), Convert.ToDecimal(446));
            contaLuz.pagar(445);
            Console.WriteLine(contaLuz);
        }
    }
    class Boleto {
        private string codBarras;
        private DateTime dataEmissao, dataVencimento, dataPagto = new DateTime(1999, 01, 01);
        private decimal valorBoleto, valorPago = 0;
        private Pagamento situacaoPagamento = Pagamento.emAberto;
        public Boleto (string cod, DateTime emissao, DateTime venc, decimal valor) {
            this.codBarras = cod;
            this.dataEmissao = emissao;
            this.dataVencimento = venc;
            this.valorBoleto = valor;
        }
        public void pagar (decimal valorPago) {
            this.valorPago = valorPago;
            Situacao();
        }
        public Pagamento Situacao() {
            Pagamento situacaoAberto = Pagamento.emAberto;
            Pagamento situacaoParcial = Pagamento.pagoParcial;
            Pagamento situacaoPago = Pagamento.pago;

            Pagamento situacaoFinal = situacaoAberto;

            if (valorPago == 0) {
                situacaoFinal = situacaoAberto;
                this.situacaoPagamento = situacaoAberto;
            }
            else if (valorPago > 0 && valorPago < valorBoleto) {
                situacaoFinal = situacaoParcial;
                this.situacaoPagamento = situacaoParcial;
                dataPagto = DateTime.Now;
            }
            else if (valorPago >= valorBoleto){
                situacaoFinal = situacaoPago;
                this.situacaoPagamento = situacaoPago;
                dataPagto = DateTime.Now;
            }
            
            return situacaoFinal;
        }
        public override string ToString()
        {
            return $"Código de Barras = {codBarras} \nEmissão = {dataEmissao} \nVencimento = {dataVencimento} \nValor = {valorBoleto} \nSituação = {situacaoPagamento} \nValor Pago = {valorPago} \nData do Pagamento = {dataPagto.Date} ";
        }
    }
    enum Pagamento {
        emAberto = 1, pagoParcial = 2, pago = 3
    }
}

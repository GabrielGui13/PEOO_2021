using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Estagio gabriel = new Estagio("Gabriel", "Google");
            gabriel.iniciar(new DateTime(2021, 01, 01));
            gabriel.finalizar(new DateTime(2021, 03, 24));
            Console.WriteLine(gabriel); 
        }
    }
    class Estagio {
        private string estagiario, empresa;
        public DateTime dataInicio, dataCancelamento, dataFim;
        private int situacao;
        public Estagio (string est, string emp) {
            this.situacao = (int) SituacaoEstagio.cadastrado;
            this.estagiario = est;
            this.empresa = emp;
        }
        public bool iniciar (DateTime data) {
            if (this.situacao == 1) {
                this.situacao = (int) SituacaoEstagio.iniciado;
                this.dataInicio = data;
                return true;
            }
            return false;
        }
        public bool cancelar (DateTime data) {
            if (this.situacao == 2) {
                this.situacao = (int) SituacaoEstagio.cancelado;
                this.dataCancelamento = data;
                return true;
            }
            return false;
        }
        public bool finalizar (DateTime data) {
            if (this.situacao == 2) {
                this.situacao = (int) SituacaoEstagio.finalizado;
                this.dataFim = data;
                return true;
            }
            return false;
        }
        public TimeSpan tempoEstagio() {
            TimeSpan resultadoFim = dataFim.Subtract(dataInicio);
            TimeSpan resultadoCanc = dataCancelamento.Subtract(dataInicio);
            TimeSpan result;

            if (mostrarSituacao() == (int) SituacaoEstagio.finalizado) result = resultadoFim;
            else result = resultadoCanc;

            return result;
        }
        public int mostrarSituacao() {
            return situacao;
        }
        public override string ToString() {
            return $"Nome = {estagiario} \nEmpresa = {empresa} \nData de Início = {dataInicio} \nData final = {(dataCancelamento.Subtract(dataInicio) == tempoEstagio() ? dataCancelamento : dataFim)} \nTempo de Estágio = {tempoEstagio().Days} dias";
        }
    }
    enum SituacaoEstagio : int {
        cadastrado = 1, iniciado = 2, cancelado = 3, finalizado = 4
    }
    
}

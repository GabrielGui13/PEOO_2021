using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Estagio gabriel = new Estagio("Gabriel", "Google");
            gabriel.iniciar(new DateTime(2021, 01, 01));
            gabriel.finalizar(new DateTime(2021, 03, 25));
            //Console.WriteLine(gabriel); 
            Console.WriteLine(gabriel.mostrarSituacao());
        }
    }
    class Estagio {
        private string estagiario, empresa;
        private DateTime dataInicio, dataCancelamento, dataFim;
        private int situacao;
        public Estagio (string est, string emp) {
            this.situacao = this.situacao = (int) SituacaoEstagio.cadastrado;
; 
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
            if (situacao == 3) {
                TimeSpan resultado = dataCancelamento.Subtract(dataInicio);
            }
            if (situacao == 4) {
                TimeSpan resultado = dataFim.Subtract(dataInicio);
            }
            return resultado;
        }
        public int mostrarSituacao() {
            return situacao;
        }
        public override string ToString()
        {
            return $"Nome = {estagiario} \nEmpresa = {empresa} \nData de Início = {dataInicio} \nTempo de Estágio = {tempoEstagio()}";
        }
    }
    enum SituacaoEstagio : int {
         cadastrado = 1, iniciado = 2, cancelado = 3, finalizado = 4
    }
    
}

using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args) {
            Data x = new Data("23/03/2021");
            Data y = new Data(23, 03, 2021);
            Data z = new Data("01/01/2021");
            z.setData(23, 03, 2021);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
    class Data {
        private int dia, mes, ano;
        public Data (string date) {
            string[] quebrarData = date.Split("/");

            this.dia = int.Parse(quebrarData[0]);
            this.mes = int.Parse(quebrarData[1]);
            this.ano = int.Parse(quebrarData[2]);
        }
        public Data (int dia, int mes, int ano) {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public void setData(int dia, int mes, int ano) {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public int getDia() {
            return dia;
        }
        public int getMes() {
            return mes;
        }
        public int getAno() {
            return ano;
        }
        public override string ToString() {
            if (mes.ToString().Substring(0, 1) == "0") return $"{dia}/{mes}/{ano}";
            else return $"{dia}/0{mes}/{ano}";
        }
    }
}

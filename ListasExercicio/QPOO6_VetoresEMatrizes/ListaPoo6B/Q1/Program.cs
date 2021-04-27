using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Colecao x = new Colecao(6);
            x.inserir("Fonti");
            x.inserir(15);
            x.inserir("Cliver");
            x.inserir(69);
            x.inserir(true);
            Console.WriteLine(x.retornarItens());
        }
    }
    class Colecao {
        private object[] itens;
        private object itensArray = "Itens = ";
        private int max = 0;
        //private string retornarArray = "";
        public Colecao (int max) {
            this.itens = new object[max];
        }
        public void inserir (object item) {
            this.itens[max] = item;
            max++;
        }
        public object[] listar() {          
            return itens;
        }
        public object retornarItens () {
            for (int i = 0; i < max; i++) {
                if (i != max - 1) itensArray += itens[i] + ", ";
                else itensArray += itens[i] + ".";
            }
            return this.itensArray;
        }
        public int numItens() {
            return this.max;
        }
    }
}

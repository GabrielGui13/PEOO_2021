using System;
using System.Collections;
using System.Collections.Generic;

namespace Caminhão_de_Frete
{
    class Program
    {
        static void Main(string[] args)
        {
            Caminhao cam1 = new Caminhao("Toyota Mark II", 15000);
            Item parque = new Item{Nome = "Parque de Jardim", Peso = 1500};
            Item videogames = new Item{Nome = "Videogames", Peso = 1000};
            Item sofa = new Item{Nome = "Sofa", Peso = 800};
            Item carro1 = new Item{Nome = "Ferrari", Peso = 1200};
            Item carro2 = new Item{Nome = "Lamborghini", Peso = 1300};
            cam1.Add(parque);
            cam1.Add(videogames);
            cam1.Add(sofa);
            cam1.Add(carro1);
            cam1.Add(carro2);

            Viagem v = new Viagem("Natal", "São Paulo", 2919, 0.9, cam1);

            //cam1.retornarCarga().Pop();
            //cam1.Retirar(parque);
            /* foreach (Item i in cam1) {
                Console.WriteLine(i);
            } */

            Console.WriteLine(v.Info());
        }
    }
    class Item {
        public string Nome {
            get; set;
        }
        public int Peso {
            get; set;
        }
        public override string ToString()
        {
            return $"{Nome} ({Peso}kg)";
        }
    }
    class Caminhao : IEnumerable {
        private Stack<Item> carga = new Stack<Item>();
        private string ModeloCaminhao;
        private double pesoCarga, cargaMax;
        public Caminhao(string m, int c) {
            this.ModeloCaminhao = m;
            this.cargaMax = c;
        }
        public void Add(Item item) {
            carga.Push(item);
            pesoCarga += item.Peso;
        }
        public void Retirar(Item item) {
            Item[] arrayRetirar = new Item[carga.Count];
            Stack<Item> cargaAjuste = new Stack<Item>();

            carga.CopyTo(arrayRetirar, 0);
            int posicao = Array.IndexOf(arrayRetirar, item);

            for (int i = posicao; i < arrayRetirar.Length - 1; i++) {
                arrayRetirar[i] = arrayRetirar[i + 1];
            }
            Array.Resize(ref arrayRetirar, carga.Count - 1);
            
            for (int y = 0; y < carga.Count - 1; y++) {
                cargaAjuste.Push(arrayRetirar[y]);
            }
            this.carga = cargaAjuste;
            pesoCarga -= item.Peso;
        }
        public IEnumerator GetEnumerator() {
            return carga.GetEnumerator();
        }
        public string Info() {
            return $"Caminhão = {ModeloCaminhao} \nCarga Máxima = {cargaMax}kg \nCarga Utilizada = {pesoCarga}kg \nCarga Disponível = {(pesoCarga > cargaMax ? "Carga Excedida" : $"{cargaMax - pesoCarga}kg restantes")}";
        }
        public double getCargaMax() {
            return cargaMax;
        }
        public double getCargaAtual() {
            return pesoCarga;
        }
        public int getTotalItens() {
            return carga.Count;
        }
        public Stack<Item> retornarCarga() {
            return carga;
        }
        public override string ToString()
        {
            return $"Modelo = {ModeloCaminhao} Carga = {pesoCarga}kg";
        }
    }
    class Viagem {
        public string inicio, destino, situacaoViagem;
        public double distancia, valor, valorTotal;
        public Caminhao caminhao;
        public Viagem (string i, string d, double di, double v, Caminhao c) {
            this.inicio = i;
            this.destino = d;
            this.distancia = di;
            this.valor = v;
            this.caminhao = c;
            CalcTotal();
        }
        public void CalcTotal() {
            double PorcentagemCarga = 0;
            if (caminhao.getCargaAtual() <= 0) PorcentagemCarga = 0;
            else if (caminhao.getCargaAtual() <= caminhao.getCargaMax() / 3 && caminhao.getCargaAtual() > 0) PorcentagemCarga = 1;
            else if (caminhao.getCargaAtual() > caminhao.getCargaMax() / 3 && caminhao.getCargaAtual() <= (caminhao.getCargaMax() / 3) * 2) PorcentagemCarga = 1.25;
            else if (caminhao.getCargaAtual() > (caminhao.getCargaMax() / 3) * 2 && caminhao.getCargaAtual() < caminhao.getCargaMax()) PorcentagemCarga = 1.5;
            else if (caminhao.getCargaAtual() > caminhao.getCargaMax()) PorcentagemCarga = -1;

            if (PorcentagemCarga == 0) {
                situacaoViagem = "Sem carga";
                valorTotal = 0;
            }
            else if (PorcentagemCarga == -1) {
                situacaoViagem = "Carga Excedida";
                valorTotal = 0;
            }
            else {
                situacaoViagem = "Carga autorizada";
                valorTotal = distancia * valor * PorcentagemCarga;
            }
        }
        public string Info() {
            return $"Inicio = {inicio} \nDestino = {destino} \nDistancia = {distancia}km \nValor Parcial = R${valor}/km \nValor Total = R${(valorTotal != 0 ? $"{valorTotal:.00}" : 0)} \nCarga = {caminhao.getCargaAtual()}kg \nItens = {caminhao.getTotalItens()} itens \nSituação = {situacaoViagem}";
        }
        public override string ToString()
        {
            return $"{inicio} {destino} {distancia}";
        }
    }
}

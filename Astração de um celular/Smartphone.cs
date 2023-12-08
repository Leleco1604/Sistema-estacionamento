using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public double TamanhoTela { get; set; }
        public int CapacidadeBateria { get; set; }

        public Smartphone(string numero, string modelo, string marca, double tamanhoTela, int capacidadeBateria)
        {
            Numero = numero;
            Modelo = modelo;
            Marca = marca;
            TamanhoTela = tamanhoTela;
            CapacidadeBateria = capacidadeBateria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}

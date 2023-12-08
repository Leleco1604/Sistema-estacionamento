using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public string Modelo { get; set; }
        public double TamanhoTela { get; set; }
        public int CapacidadeBateria { get; set; }

        public Nokia(string numero, string modelo, double tamanhoTela, int capacidadeBateria)
            : base(numero)
        {
            Modelo = modelo;
            TamanhoTela = tamanhoTela;
            CapacidadeBateria = capacidadeBateria;
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja da Nokia...");
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no Nokia {Modelo}!");
        }
    }
}

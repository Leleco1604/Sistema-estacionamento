using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }

        public Iphone(string numero, string modelo, string sistemaOperacional)
            : base(numero)
        {
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Verificação do sistema operacional
            if (SistemaOperacional == "iOS")
            {
                Console.WriteLine($"Instalando {nomeApp} na App Store do iPhone {Modelo}...");
                Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no iPhone {Modelo}!");
            }
            else
            {
                Console.WriteLine($"Não é possível instalar {nomeApp} - Incompatível com o sistema iOS.");
            }
        }
    }
}

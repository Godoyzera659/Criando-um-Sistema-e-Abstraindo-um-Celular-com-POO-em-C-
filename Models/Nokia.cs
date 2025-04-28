namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia, chamando o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;  // Atribui o valor de memória passado para a propriedade Memoria
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo no Nokia...");
            Console.WriteLine($"Nome do aplicativo: {nomeApp}");
        }
    }
}
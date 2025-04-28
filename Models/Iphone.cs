namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone, agora com a assinatura correta
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;  // Atribui o valor de memória passado para a propriedade Memoria
        }

        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo no iPhone...");
            Console.WriteLine($"Nome do aplicativo: {nomeApp}");
        }
    }
}
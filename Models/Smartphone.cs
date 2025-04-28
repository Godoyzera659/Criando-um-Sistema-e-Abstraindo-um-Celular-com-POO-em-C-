namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }  // Alterei para ser uma propriedade

        // Construtor da classe base, com a assinatura corrigida
        public Smartphone(string numero)
        {
            Numero = numero;
            Memoria = 16;  // Defini um valor padrão para Memoria, mas pode ser sobrescrito
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
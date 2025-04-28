using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Console.WriteLine("Smartphone Nokia:");
        Nokia n1 = new Nokia("99999-9999", "nokia tijolo", "1234", 64);
        n1.Ligar(); // Testando o método Ligar
        n1.InstalarAplicativo("Whatsapp"); // Testando o método InstalarAplicativo

        // Criando um objeto Iphone
         Console.WriteLine("Smartphone Nokia:");
        Iphone i1 = new Iphone("88888-8888", "iPhone 17", "5678", 128);
        i1.ReceberLigacao(); // Testando o método ReceberLigacao
        i1.InstalarAplicativo("Instagram"); // Testando o método InstalarAplicativo
    }
}
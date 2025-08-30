using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criando um Nokia
        Nokia nokia = new Nokia("1234-5678", "3310", "Nokia");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Criando um iPhone
        Iphone iphone = new Iphone("9876-5432", "iPhone 14", "Apple");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}

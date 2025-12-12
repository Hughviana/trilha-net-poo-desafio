using DesafioPOO.Models;

Nokia nokia = new Nokia("6123456789", "Nokia 12345", "IMEI1234567890", 256);
Iphone iphone = new Iphone("6198765432", "iPhone 13", "IMEI0987654321", 512);

Console.WriteLine("Qual celular você quer usar? (Nokia/Iphone): ");
string celular = Console.ReadLine();

if (celular == "Nokia")
{
    Console.WriteLine("Usando o nokia");

    nokia.Ligar();
    nokia.InstalarAplicativo("WhatsApp");
    nokia.ReceberLigacao();
}

else
{
    Console.WriteLine("Usando o iphone");
    iphone.Ligar();
    iphone.InstalarAplicativo("Instagram");
    iphone.ReceberLigacao();
}

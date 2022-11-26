using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"21777777", modelo: "Modelo 1", imei:"11111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero:"218888888", modelo: "Modelo 2", imei:"222222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
using DesafioPOO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "NK1", imei:"NK11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "789123", modelo: "IP1", imei:"IP11111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
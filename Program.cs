using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "Modelo 2", imei: "1111111111", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
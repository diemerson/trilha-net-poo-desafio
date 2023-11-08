using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "67981520147", modelo: "1100", "IMEI1995571-0", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "67981248114", modelo: "19 - PRO MAX MEGA TURBO ULTRA POWER", "IME999999999999999999999-0", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
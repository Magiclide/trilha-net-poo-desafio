using DesafioPOO.Models;
Console.WriteLine("Smarthphone Nokia: ");
Smartphone Nokia = new Nokia("9977477077","J7","1330",8);
Nokia.ReceberLigacao();
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone Iphone = new Iphone("9974522545","A2","2550",8);
Console.WriteLine("Smarthphone Iphone: ");
Iphone.ReceberLigacao();
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");


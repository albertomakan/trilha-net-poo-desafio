using DesafioPOO.Models;

//Implementado!!

Nokia nokia = new Nokia("81 9.9999-8765", "N10", "AFAI9420410FMO", 4);
Iphone iphone = new Iphone("81 9.8888-7777", "15 Pro Max", "IAMIANIAN2424254", 8);
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine(" \n ---------------------------------- \n");
iphone.InstalarAplicativo("Whatsapp");
iphone.Ligar();
iphone.ReceberLigacao();
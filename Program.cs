using DesafioPOO.Models;


// IMPLEMENTADO !
Iphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

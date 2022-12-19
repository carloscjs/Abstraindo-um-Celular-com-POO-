using DesafioPOO.Models;


Console.WriteLine("Teste do nokia");
Smartphone nokia = new Nokia(numero: "95877-8874", modelo: "A22", imei: "ABC2335424", memoria: 124);
nokia.Ligar();
nokia.InstalarAplicativo("facebook");


Console.WriteLine("Teste do Iphone");
Smartphone iphone = new Iphone(numero: "95622-6798", modelo: "8s", imei: "ADC1213412", memoria: 248);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("twiter");


// TODO: Realizar os testes com as classes Nokia e Iphone
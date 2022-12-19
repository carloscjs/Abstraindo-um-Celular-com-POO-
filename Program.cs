using DesafioPOO.Models;


Console.WriteLine("Teste do nokia");
Smartphone nokia = new Nokia(numero: "92222-2222", modelo: "Acabo", imei: "000000000", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("tiktok");


Console.WriteLine("Teste do Iphone");
Smartphone iphone = new Iphone(numero: "91111-1111", modelo: "14", imei: "111111111", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("stagram");


// TODO: Realizar os testes com as classes Nokia e Iphone
using DesafioPOO.Models;

Console.WriteLine("Smartpone da Nokia");
Smartphone nokia = new Nokia(numero: "99999-9999", modelo: "Modelo Android", imei: "111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Kindle");

Console.WriteLine("\n");

Console.WriteLine("Smartpone do Iphone");
Smartphone iphone = new Iphone(numero: "91111-1111", modelo: "Modelo IOS", imei: "11112222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "Spotify");

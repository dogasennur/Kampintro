// See https://aka.ms/new-console-template for more information
using OOP2;

Console.WriteLine("Hello, World!");

//Musteri musteri1 = new Musteri();
//musteri1.Adi = "engin";
//musteri1.Soyadi = "demir";
//musteri1.Id = 1;
//musteri1.TcNo = "1111111111111111";
//musteri1.MusteriNo = "159159159";
//musteri1.SirketAdi = "?";

GercekMusteri musteri1 =new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "engin";
musteri1.Soyadi = "demir";
musteri1.TcNo = "15923644887";


TuzelMusteri musteri2=new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "147258";
musteri2.SirketAdi = "kodlama.io";
musteri2.VergiNo = "3692580";



//gerçek -tüzel
//SOLID

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(musteri1);
customerManager.Add(musteri2);  
customerManager.Add(musteri3);  

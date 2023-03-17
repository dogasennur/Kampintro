// See https://aka.ms/new-console-template for more information
using metotlar;


//string urunAdi = "elma";
//double fiyati = 15;
//string aciklama = "amasya elması";

//string[] meyveler = new string[] { };

Urun urun1= new Urun(); //  classın örnegı için gereklidi
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "diyarbakır karpuzu";

Urun urun3 = new Urun();
urun3.Adi = "armut";
urun3.Fiyati = 20;
urun3.Aciklama = "iyiler yer";

Urun[] urunler = new Urun[] { urun1, urun2,urun3};


//type safe --tip güvenliği

foreach (Urun urun in urunler)
{

    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------");
}

Console.WriteLine("--------metotlar------");

//encapsulation

//İNSTANCE - ÖRNEK
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle(urun3);

sepetManager.Ekle2("elma", "kırmızı",20 ,3);
sepetManager.Ekle2("karpuz", "tatlı", 20 ,6);
sepetManager.Ekle2("armut", "yeşil", 20,8 );

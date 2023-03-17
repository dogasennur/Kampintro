// See https://aka.ms/new-console-template for more information
using ödev_denemelerim;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");



//int sayi = 20;
//string sonuc = (sayi % 2 == 0) ? "sayı çifttir" : "sayı tektir";
//Console.WriteLine(sonuc);

// buna ternary operatörü denir if elsi şart blogunundaki satırları azaltmak için kullanılabilir

//int sayi = 20;

//if (sayi % 2 == 0)
//{
//    Console.WriteLine("sayı çifttir");
//}
//else
//    Console.WriteLine("sayı tektir");


//İşlemleri yaptınız koşulu sağladığınız fakat arttırma veya azaltma işlemi yapmazsanız döngü sonsuz döngü olur.
//While kelimesinin Türkçe anlamı iken demektir. Yani koşul sağlanıyorken devam et işlem yap demekti

//int i = 10;
//while (i < 5)
//{
//    console.writeline(i);
//    i++;
//}




Product urun1 = new Product();
urun1.UrunAdi = "çilek";
urun1.UrunFiyati = 10;

Product urun2 = new Product();
urun2.UrunAdi = "armut";
urun2.UrunFiyati = 5;

Product urun3 = new Product();
urun3.UrunAdi = "elma";
urun3.UrunFiyati = 20;


Product[] urunler = new Product[] { urun1, urun2, urun3 };

foreach (Product urun in urunler)
{
    Console.WriteLine(urun.UrunAdi + ":" + urun.UrunFiyati);
}

Console.WriteLine("foreach döngü bitişi");

for (int i = 0; i <urunler.Length; i++)
{
    Console.WriteLine("ürün adı" + "-" + urunler[i].UrunAdi + "-" + "fiyat"+"-"+ urunler[i].UrunFiyati);
}



//int i =3;

//while (i<=3)
//{
//    Console.WriteLine(i);
//    i++;
//}
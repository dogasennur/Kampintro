// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

//type safety tip güvenliği
//do not repeat yourself

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000; //sınırları olan veri tipi
double faizOrani = 1.45 ; //ondalık veri tipi
double dolarDun = 7.35;
double dolarBugun = 7.35;

if (dolarDun > dolarBugun)
{
    Console.WriteLine("azalış göster");
}

else if (dolarDun < dolarBugun)
{
    Console.WriteLine(" artış göster");
}

else 
{
    Console.WriteLine("dolar sabit");
}

Console.WriteLine(kategoriEtiketi);

bool sistemeGirisYapmişMi = true; //true false durumuna göre sistemde if yada else çalışacak

if (sistemeGirisYapmişMi== true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("giriş yap butonu");
}






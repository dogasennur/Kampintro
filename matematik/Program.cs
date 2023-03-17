// See https://aka.ms/new-console-template for more information
using matematik;

Console.WriteLine("Hello, World!");

DortIslem dortislem = new DortIslem();
dortislem.Topla(5, 5);
dortislem.Çıkart(5, 5);
dortislem.Çarp(5, 5);
dortislem.Böl(5, 5);
Console.WriteLine("diğer sayılara geçiniz");
dortislem.Topla(6, 1);
dortislem.Çıkart(6, 1);
dortislem.Çarp(6, 1);
dortislem.Böl(6, 1);
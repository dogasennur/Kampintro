using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2) //ihtiyaclar
        {

            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuç:"+ toplam);

         
         }
        public void Çıkart(int sayi1, int sayi2)
        {

            int çıkart = sayi1 - sayi2;
            Console.WriteLine("sonuç:" + çıkart);

        }
        public void Çarp(int sayi1, int sayi2)
        {
            int çarp = sayi1 * sayi2;
            Console.WriteLine("sonuç:" + çarp);

        }
        public void Böl(int sayi1, int sayi2)
        {
            int böl = sayi1 / sayi2;
            Console.WriteLine("sonuç:" + böl);

        }
        
    }
}

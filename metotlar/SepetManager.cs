﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    class SepetManager
    {
        //name convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" tebrikler sepete eklendi: "+ urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama , double fiyat, int stokAdedi) 
        {
        
        Console.WriteLine(" tebrikler sepete eklendi: " + urunAdi);
        }


    }

}

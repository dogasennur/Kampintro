﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop3
{
    internal class BasvuruManager
    {//methode injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) 
        {
            //başvuru bilgilerini değerlendirme

            krediManager.Hesapla();
            loggerService.Log();
        }    

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler ) 
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        
        } 

    }
}

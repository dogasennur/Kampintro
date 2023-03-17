using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericsintro
{
    internal class MyList<T>

    {
        //aray oluşturduk arrray referans tip oldugu için newlwnmwsi lazım
        T[] items;

        //constructor bir class newlwndiğinde çalışan bloga denir
        public MyList()
        {
            items = new T[0];

        }

        public void Add(T item)
        {
            T[] tempArray = items;   //geçici array önceki verileri tutsun diye
            items = new T[items.Length + 1];
            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;   //son eleman
        }
        public int Count
        {
            get { return items.Length; }
        }


    }
}

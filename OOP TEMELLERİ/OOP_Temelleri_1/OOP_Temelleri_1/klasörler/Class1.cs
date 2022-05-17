using OOP_Temelleri_1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.klasörler
{
    /* sınıfların içindeki öğelere erişim sağlamak
    için sınıftan bir nesne türetilir */
    // SınıfAdı nesneAdı=new SınıfAdı();
    public class Class1
    {
        //sınıf içerisindeki öğelere erişim sağlamak için
        //bu sınıfın mutlaka bir metotun içinde tanımlanmalı
        /*void Metot()
        {
            Product product= new Product();
            product.
        }*/

        // geriye değer döndürmeyen metot
       public void Topla()
        {
            int sayi1 = 10;
            int sayi2 = 20;
            int sonuc = sayi1 + sayi2;
        }
        void Carp()
        {
            int s1 = 10;
            int s2 = 20;
            int sonuc = s1 * s2;
        }




    }
}

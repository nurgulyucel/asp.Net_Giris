using Microsoft.AspNetCore.Mvc;
using OOP_Temelleri_1.klasörler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.Controllers
{
    public class DefaultController1 : Controller
    {
       // int sayi;
       //  int sayi2;
       // int toplam = sayi; hata verir metot içinde yaz der
       //void islemler()
       // {
       //     Class1 c = new Class1();
       //     c.Topla();

       // }

        //tasarım kısmı
        void messages()
        { //ViewBag: controllerdan view tarafına bir şey 
          //taşımak için kullanılır.
            ViewBag.m1 = "Merhaba Bu Bir Core Porjesi";
            ViewBag.m2 = "merhaba bu proje çok iyi duruyor";
            ViewBag.m3 = "selamlar hi hello bonjour";
        } //bu kısım birden fazla yerde yer alabilir.

        //geriye deger dondurmeyen metot
        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;

        }
        int cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);
            return sonuc;
        }

        string cumle()
        {
            string c= "Küçük hanımlar Küçük Beyler ";
            return c;
        }

        //parametre kullanımı
        void MesajListesi(string p)
        {
            ViewBag.v = p;

        }

        void Kullanıcı (string username)
        {
            ViewBag.u = username;
        }

        int Topla(int s1,int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Faktoriyel(int k)
        {
            int f = 1;
            for(int i=1;i<=k;i++)
            {
                f = f * i;
            }
            return f;
        }




        public IActionResult Index()
        {
            messages();
            MesajListesi("Parametre ismi");
            Kullanıcı("üye");
            ViewBag.g = Topla(3,5);
            ViewBag.faktor = Faktoriyel(6);

            return View();

        }

        public IActionResult Urunler()
        {
            messages();
            ViewBag.t = topla();
            ViewBag.c = cevre();
            Kullanıcı("üye51");
            return View();
        }
        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            Kullanıcı("üye06");
            return View();
        }

        public IActionResult Deneme()
        {
            //Sehirler sınfındaki nitelikleri kullanabilmek için
            //bir nesne türettim.
            Sehirler sehirler = new Sehirler();
            

            //nesne aracılığıyla proportylere değer ataması yaptım.
            sehirler.sehirAd = "Niğde";
            sehirler.sehirId = 1;
            sehirler.nufus = 125000;
            sehirler.ulke = "Turkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";
            

            //değer ataması yaptığım değerleri ekrana yazdırmak için
            //viewBag den yararlandım.
            ViewBag.f1 = sehirler.sehirAd;
            ViewBag.f2 = sehirler.sehirId;
            ViewBag.f3 = sehirler.nufus;
            ViewBag.f4 = sehirler.ulke;
            ViewBag.f5 = sehirler.Renk1;
            ViewBag.f6 = sehirler.Renk2;
            

            sehirler.sehirAd = "Ankara";
            sehirler.sehirId = 2;
            sehirler.nufus = 725000000;
            sehirler.ulke = "Turkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";
            ViewBag.z1 = sehirler.sehirAd;
            ViewBag.z2 = sehirler.sehirId;
            ViewBag.z3 = sehirler.nufus;
            ViewBag.z4 = sehirler.ulke;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;



            //geriye view döndürdüm.
            return View();
        }

    }
}

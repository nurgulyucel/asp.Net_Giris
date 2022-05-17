using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.klasörler
{
    public class Sehirler:Bayrak
        //sehirler sınıfı bayrak sınıfına ait bütün nietlikleri 
        //üzerine aldı. kalıtım
    {
        public int sehirId { get; set; }
        public string sehirAd { get; set; }
        public int nufus { get; set; }
        public string ulke { get; set; }
    }
}

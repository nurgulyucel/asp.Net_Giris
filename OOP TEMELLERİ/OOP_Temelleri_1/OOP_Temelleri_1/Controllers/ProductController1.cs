using Microsoft.AspNetCore.Mvc;
using OOP_Temelleri_1.Entity;
using OOP_Temelleri_1.ProjeContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Temelleri_1.Controllers
{
    public class ProductController1 : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.products.ToList();
            // toList ile bana ürün sınıfında yer alan değerleri
            //getir.Getirdiğin bu değerleri values isimli değişkene
            //ata.Geriye valuesi döndür ki view tarafında karşılansın.
            return View(values);
        }

        ////ürün ekleme
        [HttpGet]
        public IActionResult AddProduct()
        {

            return View();
        }
        // gönderme islemi
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            // verileri kaydetmek için entity framework de add 
            //metotu kullanılıyor.
            context.Add(p);
            context.SaveChanges(); //değişiklikleri kaydet

            return RedirectToAction("Index");
            //beni actiona yönlendir.
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = context.products.Where(x => x.ProductId == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = context.products.Where(x => x.ProductId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            var value = context.products.Where(x => x.ProductId == p.ProductId).FirstOrDefault();
            value.ProductName = p.ProductName;
            value.ProductPrice = p.ProductPrice;
            value.stok = p.stok;
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Products.Controllers
{
    public class ProizvodController : Controller
    {
        ProizvodiDataContext proizvodDC = new ProizvodiDataContext();
        // GET: Proizvod
        public ActionResult Index()
        {

            return View(proizvodDC.Proizvods.ToList());


        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(FormCollection fc ) 
        {
            Proizvod proizvod = new Proizvod();
            proizvod.Naziv = fc["Naziv"];
            proizvod.Opis = fc["Opis"];
            proizvod.Proizvodjac = fc["Proizvodjac"];
            proizvod.Kategorija = fc["Kategorija"];
            proizvod.Cena = Convert.ToDouble(fc["Cena"]);
            proizvod.Dobavljac = fc["Dobavljac"];
            try
            {
                proizvodDC.Proizvods.InsertOnSubmit(proizvod);
                proizvodDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
           
        }
        public ActionResult Delete(int id)
        {
            Proizvod proizvod = (from p in proizvodDC.Proizvods
                                 where p.ID == id
                                 select p).Single();
            try
            {
                proizvodDC.Proizvods.DeleteOnSubmit(proizvod);
                proizvodDC.SubmitChanges();
                return RedirectToAction("Index");

            }
            catch
            {
               
                return RedirectToAction("Index");
            }
                                
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Proizvod proizvod = (from pr in proizvodDC.Proizvods where pr.ID == id select pr).Single();
            return View(proizvod);
        }
        
        [HttpPost]
        public ActionResult Edit(int id, FormCollection fc)
        {
            Proizvod proizvod = (from pro in proizvodDC.Proizvods where pro.ID == id select pro).Single();
            proizvod.Naziv = fc["Naziv"];
            proizvod.Kategorija = fc["Kategorija"];
            proizvod.Opis = fc["Opis"];
            proizvod.Proizvodjac = fc["Proizvodjac"];
            proizvod.Dobavljac = fc["Dobavljac"];
            proizvod.Cena = Convert.ToDouble(fc["Cena"]);


            try
            {
                proizvodDC.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
               return RedirectToAction("Index");
            }
        }
    }

}
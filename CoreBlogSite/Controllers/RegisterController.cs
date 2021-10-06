using BusinessLayer.Concrete;
using CoreBlogSite.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogSite.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CityViewModel cities = new CityViewModel();
        public List<string> GetCity()
        {
            String[] Cities = new String[] { "Adana", "Adıyaman", "Afyon", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Bartın", "Batman", "Balıkesir", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin", "Mersin","Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Şırnak", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
            return new List<string>(Cities);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new CityViewModel();
            model.Cities = new List<SelectListItem>();
            model.Cities.Add(new SelectListItem() { Text = "Adana", Value = "1", Selected = false });
            model.Cities.Add(new SelectListItem() { Text = "Adıyaman", Value = "1", Selected = false });
            model.Cities.Add(new SelectListItem() { Text = "Afyon", Value = "1", Selected = false });
            model.Cities.Add(new SelectListItem() { Text = "Ağrı", Value = "1", Selected = false });
            model.Cities.Add(new SelectListItem() { Text = "Aksaray", Value = "1", Selected = false });
            model.Cities.Add(new SelectListItem() { Text = "Amasya", Value = "1", Selected = false });

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "Test test test";
            wm.WriterAdd(p);
            return RedirectToAction("Index", "Blog");
        }

    }
}

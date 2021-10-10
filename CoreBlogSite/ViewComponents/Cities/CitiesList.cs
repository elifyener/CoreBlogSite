using CoreBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogSite.ViewComponents.Cities
{
    public class CitiesList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cityvalues = new List<CityViewModel>
            {
                new CityViewModel
                {
                    CityID = 1,
                    CityName = "Ankara"
                },
                new CityViewModel
                {
                    CityID = 2,
                    CityName = "İstanbul"
                },
                new CityViewModel
                {
                    CityID = 3,
                    CityName = "İzmir"
                },
                new CityViewModel
                {
                    CityID = 4,
                    CityName = "Samsun"
                }
            };

            List<SelectListItem> valuecity = (from x in cityvalues
                                              select new SelectListItem
                                              {
                                                  Text = x.CityName,
                                                  Value = x.CityID.ToString()
                                              }).ToList();
            ViewBag.vlc = valuecity;
            return View();
        }
    }
}

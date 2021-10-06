using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogSite.Models
{
    public class CityViewModel
    {
        public string CityName { get; set; }

        public List<SelectListItem> Cities { get; set; }

    }
}

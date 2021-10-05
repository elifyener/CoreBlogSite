using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogSite.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        public PartialViewResult Partial2()
        {
            return PartialView();
        }
        public PartialViewResult Partial3()
        {
            return PartialView();
        }
    }
}

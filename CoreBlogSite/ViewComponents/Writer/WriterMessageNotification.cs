using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogSite.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2Manager m2m = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 1;
            var values = m2m.GetInboxListByWriter(id);
            return View(values);
        }
    }
}

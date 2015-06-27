using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Classified.Web.Areas.User.Controllers
{
    public class AdvertisementController : Controller
    {
        // GET: Advertisement
        public ActionResult Index()
        {
            return View();
        }
    }
}
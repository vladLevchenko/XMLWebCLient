using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMLProcesser.Interfaces;

namespace XMLWebClient.Controllers
{
    public class IndexController : Controller
    {
        private IXMLModule _xmlService;
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VirtualBoxPOC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new FileModel());
        }

        [HttpPost]
        public ActionResult Index(FileModel model)
        {
            model.Contents = System.IO.File.ReadAllText(model.Path);
            return View(model);
        }

    }

    public class FileModel
    {
        public string Path { get; set; }
        public string Contents { get; set; }
    }
}

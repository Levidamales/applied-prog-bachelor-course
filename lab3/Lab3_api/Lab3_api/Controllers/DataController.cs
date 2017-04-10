using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Lab3_api.Controllers
{
    public class DataController : Controller
    {
        public JsonResult Read(string path)
        {
            StreamReader stream = new StreamReader(path);
            string content = stream.ReadToEnd();
            return Json(content, JsonRequestBehavior.AllowGet);
        }
    }
}
//C:\Users\samae_000.SATANS_TOWER\Desktop\test.txt
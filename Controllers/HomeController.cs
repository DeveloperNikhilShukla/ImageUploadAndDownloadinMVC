using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageUploadAndDownloadInMVC.Models;
namespace ImageUploadAndDownloadInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FileUploaderUpdate(Employee _Employee)
        {
            string path = Server.MapPath("~/uploadfile");
            string filename =Path.GetFileName(_Employee.file.FileName);
            string FullPath = Path.Combine(path, filename);
            _Employee.file.SaveAs(FullPath);


            return View("index");
        }

        public FileResult Download(Employee _Employee)
        {
            string path = Server.MapPath("~/uploadfile");
            string filename = Path.GetFileName("excel.html");
            string FullPath = Path.Combine(path, filename);
           // _Employee.file.SaveAs(FullPath);
            return File(FullPath, "text/html","DownloadData.html");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
    public ActionResult Index(HttpPostedFileBase postedFile)
    {
        string path = Server.MapPath("~/Uploads/");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
 
        if (postedFile != null)
        {
            string fileName = Path.GetFileName(postedFile.FileName);
            postedFile.SaveAs(path + fileName);
            ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
        }
 
        return View();
    }
    }
}

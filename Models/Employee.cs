using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageUploadAndDownloadInMVC.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public HttpPostedFileBase file{get;set;}
    }
}
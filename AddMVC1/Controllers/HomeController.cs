using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AddMVC1
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //public string Index()
        //{
        //    return "Coming from index";
        //}

        public JsonResult Index()
        {
            return Json(new { msg = "Coming from index"});
        }
    }
}

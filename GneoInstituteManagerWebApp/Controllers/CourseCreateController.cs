using GneoCommonDataLibrary.ViewModels;
using GneoInstituteManagerWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GneoInstituteManagerWebApp.Controllers
{
    public class CourseCreateController : Controller
    {
        HttpClient client;

        public CourseCreateController(string strURL)
        {
            Uri baseAddress = new Uri(strURL);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}

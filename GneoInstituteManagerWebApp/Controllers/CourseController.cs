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
    public class CourseController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44390/api");
        HttpClient client;

        public CourseController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }


        public IActionResult All()
        {
            List<CourseViewModel> courseList = new List<CourseViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Course/all").Result;


            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                courseList = JsonConvert.DeserializeObject<List<CourseViewModel>>(data);
            }
            return View(courseList);
        }
    }
}

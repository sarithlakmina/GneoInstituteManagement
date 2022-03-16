using GneoCommonDataLibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GneoWebAPI.Controllers
{
    public class TeachersViewModelController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44325");
        HttpClient client;

        [HttpGet]
        [Route("all")]
        public IActionResult GetAllTeachers()
        {
            List<CourseViewModel> courseList = new List<CourseViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Teacher/all").Result;

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                courseList = JsonConvert.DeserializeObject<List<CourseViewModel>>(data);
            }
            return View(courseList);
        }
    }
}

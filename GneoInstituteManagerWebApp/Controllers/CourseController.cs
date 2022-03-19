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
        HttpClient client;

        public CourseController(string strURL)
        {
            Uri baseAddress = new Uri(strURL);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }


        public IActionResult All()
        {
            List<CourseViewModel> courseList = new List<CourseViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/Course/all").Result;


            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                courseList = JsonConvert.DeserializeObject<List<CourseViewModel>>(data);
            }
            return View(courseList);
        }

        public IActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Enroll(EnrolledCourseViewModel enrolledCourseViewModel)
        {
            var clienturl = client.BaseAddress + "api/Course/enroll";
            var postTask = client.PostAsJsonAsync<EnrolledCourseViewModel>(clienturl, enrolledCourseViewModel);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("all");
            }

            return View();
        }
       


    }
}

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
            try
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
            catch (Exception)
            {
                return NoContent();
            }
        }

        public IActionResult Enroll()
        {
            try
            {
                List<Guid> CourseIds = new List<Guid>();
                ViewBag.CourseID = CourseIds;
                return View();
            }
            catch (Exception)
            {

                return NoContent();
            }
        }

        [HttpPost]
        public IActionResult Enroll(EnrolledCourseViewModel enrolledCourseViewModel)
        {
            try
            {
                var clienturl = client.BaseAddress + "api/Course/enroll";
                var postTask = client.PostAsJsonAsync<EnrolledCourseViewModel>(clienturl, enrolledCourseViewModel);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("all");
                }
                ViewBag.CourseID = new List<Guid>();
                return View();
            }
            catch (Exception)
            {

                return NoContent();
            }
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EnrolledCourseViewModel enrolledCourseViewModel)
        {            
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(EnrolledCourseViewModel enrolledCourseViewModel)
        {
            return View();
        }



    }
}

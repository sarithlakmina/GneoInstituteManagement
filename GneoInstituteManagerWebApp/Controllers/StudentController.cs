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
    public class StudentController : Controller
    {
        HttpClient client;

        public StudentController(string strURL)
        {
            Uri baseAddress = new Uri(strURL);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }


        public IActionResult All()
        {
            try
            {

                List<StudentViewModel> studentsList = new List<StudentViewModel>();
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/Student/all").Result;


                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    studentsList = JsonConvert.DeserializeObject<List<StudentViewModel>>(data);
                }
                return View(studentsList);
            }
            catch (Exception)
            {

                return NoContent();
            }
        }

        public IActionResult Create()
        {
            try
            {
                List<Guid> studentsList = new List<Guid>();
                ViewBag.studentsList = studentsList;
                return View();
            }
            catch (Exception)
            {

                return NoContent();
            }
        }

        [HttpPost]
        public IActionResult Create(CreateStudentViewModel createStd)
        {
            try
            {
                var clienturl = client.BaseAddress + "api/student/create";
                var postTask = client.PostAsJsonAsync<CreateStudentViewModel>(clienturl, createStd);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("all");
                }
                ViewBag.CourseID = new List<Guid>();
                return View();
            }
            catch (Exception ex)
            {

                return NoContent();
            }
        }

       
        public IActionResult Delete(Guid ID)
        {
            try
            {
                StudentViewModel svm = new StudentViewModel();
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "svm?StudentID" + ID.ToString()).Result;  //not completed
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


    }
}

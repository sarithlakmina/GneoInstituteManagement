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
    public class TeacherController : Controller
    {
        HttpClient client;

        public TeacherController(string strURL)
        {
            Uri baseAddress = new Uri(strURL);
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }


        public IActionResult All()
        {
            try
            {
                List<TeacherViewModel> teacherList = new List<TeacherViewModel>();
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/Teacher/all").Result;


                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    teacherList = JsonConvert.DeserializeObject<List<TeacherViewModel>>(data);
                }
                return View(teacherList);
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

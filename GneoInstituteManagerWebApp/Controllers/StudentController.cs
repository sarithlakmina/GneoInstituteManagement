﻿using GneoInstituteManagerWebApp.ViewModels;
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
        Uri baseAddress = new Uri("https://localhost:44390/api");
        HttpClient client;

        public StudentController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        
        public IActionResult All()
        {
            List<StudentViewModel> courseList = new List<StudentViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/Student/all").Result;
          

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                courseList = JsonConvert.DeserializeObject<List<StudentViewModel>>(data);
            }
            return View(courseList);
        }
    }
}
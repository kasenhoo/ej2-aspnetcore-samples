﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EJ2CoreSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;

namespace EJ2CoreSampleBrowser.Controllers
{
    public partial class ScheduleController : Controller
    {
        public IActionResult GroupEditing()
        {
            ViewBag.datasource = new ScheduleData().GetResourceConferenceData();

            List<ResourceDataSourceModel> conferences = new List<ResourceDataSourceModel>();
            conferences.Add(new ResourceDataSourceModel { text = "Margaret", id = 1, color = "#1aaa55" });
            conferences.Add(new ResourceDataSourceModel { text = "Robert", id = 2, color = "#357cd2" });
            conferences.Add(new ResourceDataSourceModel { text = "Laura", id = 3, color = "#7fa900" });
            ViewBag.Conferences = conferences;

            string[] resources = new string[] { "Conferences" };
            ViewBag.Resources = resources;
            return View();
        }
    }
}

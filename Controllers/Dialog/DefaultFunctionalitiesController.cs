﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        public IActionResult DefaultFunctionalities()
        {
            ViewBag.button = new
            {
                content = "Learn More",
                isPrimary = true
            };
            return View();
        }
    }
}
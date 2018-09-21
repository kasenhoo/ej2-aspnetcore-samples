﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EJ2CoreSampleBrowser.Controllers.MaskedTextbox
{
    public partial class MaskedTextboxController : Controller
    {

        public IActionResult CustomMask()
        {
            CustomCharacters customObj = new CustomCharacters();
            customObj.P = "P,A,a,p";
            customObj.M = "M,m";
            ViewBag.cusObj = customObj;
            return View();
        }
      

    }
}
public class CustomCharacters
{
    public string P { get; set; }
    public string M { get; set; }
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EJ2CoreSampleBrowser.Controllers.TreeMap
{
    public partial class TreeMapController : Controller
    {
        public IActionResult PrintAndExport()
        {
            ViewBag.dataSource = this.getDataSource("ProductSale");
            return View();
        }
    }
}
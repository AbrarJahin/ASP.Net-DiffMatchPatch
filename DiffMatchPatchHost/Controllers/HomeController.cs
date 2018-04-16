﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiffMatchPatchHost.Models;
using AbrarJahin.DiffMatch.Patch;
using System.Collections.Generic;
using System;

namespace DiffMatchPatchHost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public Object DiffMatchPatch(string firstString, string secondString)
        {
            //Garbage Collector Clearification
            GC.Collect();
            GC.WaitForPendingFinalizers();

            DateTime ms_start = DateTime.Now;
            DiffMatchPatch dmp = new DiffMatchPatch();
            dmp.DiffTimeout = 0;

            // Execute one reverse diff as a warmup.
            List<Diff> diff = dmp.DiffMain(firstString, secondString);

            return new {
                CalculationTime = DateTime.Now - ms_start,
                AllDifferences = diff,
                PrettyHtml = dmp.DiffPrettyHtml(diff)
            };
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

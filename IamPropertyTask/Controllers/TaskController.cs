﻿using IamPropertyTask.ViewModels.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IamPropertyTask.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult Home()
        {
            return View(new SubmitData { IsPalindromCSharp = false, CSharpInput = String.Empty, JavaScriptInput = String.Empty, SqlInput = String.Empty, IsPalindromSQL = false });
        }
        [HttpPost]
        public ActionResult ValidatePalindromCSharp(SubmitData data)
        {
            if (data.CSharpInput != null)
            {
                var csharpTextInput = data.CSharpInput.Replace(" ", "");
                data.IsPalindromCSharp = csharpTextInput.SequenceEqual(csharpTextInput.Reverse());
            }
            return View("home",data);
        }
       
    }
}
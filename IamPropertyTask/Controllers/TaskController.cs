using IamPropertyTask.ViewModels.Task;
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
            return View();
        }
        [HttpPost]
        public ActionResult ValidatePalindromCSharp(string csharpTextInput)
        {
            csharpTextInput = csharpTextInput.Replace(" ","");
            var isPalindrom  = csharpTextInput.SequenceEqual(csharpTextInput.Reverse());
            if(isPalindrom)
                //goes to the same view but removes changes
                //TODO: send a model with the changes that happends
                return View("home");
            return new HttpStatusCodeResult(400);
        }
       
    }
}
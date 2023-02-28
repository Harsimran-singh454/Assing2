using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assing3.Controllers
{
    public class J3DController : Controller
    {
        // GET: J3D
        public ActionResult takeInstruction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult giveInstruction(string inst)
        {
            ViewBag.inst = inst;
            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] splits = inst.Split(nums);
            string SplittedInstruction = "";
            foreach (var str in splits)
            {
                SplittedInstruction += str;
                SplittedInstruction += "\n";
            }
            string output1 = SplittedInstruction.Replace("+", " tighten ");
            string output2 = output1.Replace("-", " loosen ");
            ViewBag.output = output2;
            
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assing3.Controllers
{

    /// <summary>
    ///J3 from 2022
    //<result>
    // POST: ../api/J3/setHarp/AFB+8HC-4 --->AFB tighten 8 
    //                                       HC Loosen 4
    ///</result>


    /// </summary>
    public class J3Controller : ApiController
    {

        [HttpPost]
        [Route("api/J3/setHarp/{inst}")]
        public string setHarp(string inst)
        {
        char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
  
            string[] splits = inst.Split(nums);

            for(int i = 0; i<=inst.Length; i++)
            {
                if (char.IsDigit(inst[i]))
                {
                    Console.WriteLine(i);
                }
            }

            string ae = "";
            foreach (var str in splits)
            {
                ae += str;
                ae += "\n";
            }
            
            string output1 = ae.Replace("+", " tighten ");
            string output2 = output1.Replace("-", " loosen ");

            return output2;
        }


/// <summary>
/// 
//    char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//  string[] splits = inst.Split(nums);
//  string ae = "";
//    foreach(var str in splits)
//    {
//        ae += str;
//        ae += "\n"; 
//    }
//    string output1 = ae.Replace("+", " tighten ");
//    string output2 = output1.Replace("-", " loosen ");
//    System.Console.WriteLine(output2);

/// </summary>


    }
}

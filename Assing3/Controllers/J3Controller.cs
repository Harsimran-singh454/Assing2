using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assing3.Controllers
{

    ///J3 from 2022
    /// <summary></summary>
    ///<example> ../api/J3/setHarp/AFB+8HC-4 --->AFB tighten 8, HC Loosen 4 </example>
    ///<result></result>
    /// </summary>
    
    public class J3Controller : ApiController
    {

        [HttpPost]
        [Route("api/J3/setHarp/{inst}")]
        public string setHarp(string inst)
        {
            char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string[] splits = inst.Split(nums);
            string ae = "";
            foreach (var str in splits)
            {
                ae += str;
                ae += "\n";
            }
            string output1 = ae.Replace("+", " tighten ");
            string output2 = output1.Replace("-", " loosen ");
            return output2;
            ///System.Console.WriteLine(output2);
        }
    }
}

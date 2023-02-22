using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assing3.Controllers
{


    public class J3Controller : ApiController
    {

        // J3 from 2022

        // Input ---> AFB+8HC-4

        /* Output ---> 
         * AFB tighten 8 
         * HC Loosen 4
        */

        [HttpGet]
        [Route("api/J3/setHarp/{inst}")]
        public string setHarp(string inst)
        {

/*       This code below was working in the microsoft online.NET editor,
*       execpt I could not get the number to print
        
        So the actual results from my code were

        Input ---> AFB+8HC-4
        
         Output ---> 
         AFB tighten 
         HC Loosen
        
*/

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


/*     
 *     
 *     --------------This is the actual code that i wrote in the online compiler--------------
 *  
 * 
    string inst = "AFBF+4BDF-5";
    char[] nums = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    string[] splits = inst.Split(nums);
    string ae = "";
    foreach(var str in splits)
    {
        ae += str;
        ae += "\n"; 
    }
    string output1 = ae.Replace("+", " tighten ");
    string output2 = output1.Replace("-", " loosen ");
    System.Console.WriteLine(output2);

*/

    }
}

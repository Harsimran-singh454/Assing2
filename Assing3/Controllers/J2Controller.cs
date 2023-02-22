using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assing3.Controllers
{
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{d1}/{d2}")]
        public string DiceGame(int d1, int d2)
        {
            int count = 0;
            for(int i = 1; i<=d1; i++)
            {
                for(int j = 1; j<=d2; j++)
                {
                    if(i+j == 10)
                    {
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                return "There is " + count + " way to get sum of 10";
            } else
            {
                return "There are " + count + " ways to get sum of 10";
            }
        }
    }
}

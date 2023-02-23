using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assing3.Controllers
{
    /// <summary>
    /// This method will print the total number of ways of how if 2 dices rolled, 
    /// can give the sum of 10, depending on the user input from range of both dices 
    /// </summary>
    /// <param name="d1">the d1 paramenter represents the maximum number on the dice 1. It is of int data type</param>
    /// <param name="d2">the d2 paramenter represents the maximum number on the dice 2. It is of int data type</param>
    /// 
    /// <returns> The output will of this method will be a string containing a number 
    /// example1: GET ../api/J2/DiceGame/6/8  --> There are 5 ways to get the sum 10
    /// example2: GET ../api/J2/DiceGame/12/4 --> There are 4 ways to get the sum of 10
    /// example3: GET ../api/J2/DiceGame/3/3 --> There are 0 ways to get the sum 10
    /// 
    /// </returns>
    ///
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{d1}/{d2}")]
        public string DiceGame(int d1, int d2)
        {
            int count = 0;

            // loop for first dice
            for(int i = 1; i<=d1; i++)
            {
                // comparing one side of the first dice with every side of the second dice
                for(int j = 1; j<=d2; j++)
                {
                    // recording the number of ways
                    if (i+j == 10)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Assing3.Controllers
{
    public class J1Controller : ApiController
    {


        /// <summary>
        /// Recieves 4 inputs which are Id's for different items. In return, we will be able to see the total calories in the passed order
        /// </summary>
        /// <param name="burger"> This parameter is of data type integer and its Choice of burger from range 1 to 4 </param>
        /// <param name="drink"> This parameter is of data type integer and its Choice of drink from range 1 to 4 </param>
        /// <param name="side"> This parameter is of data type integer and its Choice of side from range 1 to 4 </param>
        /// <param name="dessert"> This parameter is of data type integer and its Choice of dessert from range 1 to 4 </param>

        /// <example> GET ../api/J1/Menu/4/4/4/4  --> Your total calorie count is 0 </example>
        /// <example> GET ../api/J1/Menu/1/2/3/4 --> Your total calorie count is 691 </example>

        /// <returns>  The function Menu will return the total number of calories of the entered choices of items  
        /// </returns>
        /// 
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            List<string> Order = new List<string>();
     
            List<int> totalCalolries = new List<int>();

            // Burgers

            int cheeseburger = 461;
            int fish_burger = 431;
            int veggie_burger = 420;
            int no_burger = 0;
            
            switch (burger)
            {
                case 1:
                    Order.Add("Cheese Burger");
                    totalCalolries.Add(cheeseburger);
                    break;
                case 2:
                    Order.Add("Fish Burger");
                    totalCalolries.Add(fish_burger);
                    break;
                case 3:
                    Order.Add("Veggie Burger");
                    totalCalolries.Add(veggie_burger);
                    break;
                case 4:
                    Order.Add("No Burger");
                    totalCalolries.Add(no_burger);
                    break;
                default:
                    Order.Add("No Burger");
                    totalCalolries.Add(no_burger);
                    break;
            }


            // Drinks
            int soft_drink = 130;
            int orange_juice = 160;
            int milk = 118;
            int no_drink = 0;

            switch (drink)
            {
                case 1:
                    Order.Add("Soft Drink");
                    totalCalolries.Add(soft_drink);
                    break;
                case 2:
                    Order.Add("Orange Juice");
                    totalCalolries.Add(orange_juice);
                    break;
                case 3:
                    Order.Add("Milk");
                    totalCalolries.Add(milk);
                    break;
                case 4:
                    Order.Add("No drink");
                    totalCalolries.Add(no_drink);
                    break;
                default:
                    Order.Add("No drink");
                    totalCalolries.Add(no_drink);
                    break;
            }

            // Side items
            int fries = 100;
            int baked_pots = 57;
            int chef_salad = 70;
            int no_side = 0;

            switch (side)
            {
                case 1:
                    Order.Add("Fries");
                    totalCalolries.Add(fries);
                    break;
                case 2:
                    Order.Add("Baked Pots");
                    totalCalolries.Add(baked_pots);
                    break;
                case 3:
                    Order.Add("Chef Salad");
                    totalCalolries.Add(chef_salad);
                    break;
                case 4:
                    Order.Add("No Side");
                    totalCalolries.Add(no_side);
                    break;
                default:
                    Order.Add("No Side");
                    totalCalolries.Add(no_side);
                    break;
            }

            // Dessert
            int apple_pie = 167;
            int sundae = 266;
            int fruit_cup = 75;
            int no_dessert = 0;

            switch (dessert)
            {
                case 1:
                    Order.Add("Apple Pie");
                    totalCalolries.Add(apple_pie);
                    break;
                case 2:
                    Order.Add("Sundae");
                    totalCalolries.Add(sundae);
                    break;
                case 3:
                    Order.Add("Fruit Cup");
                    totalCalolries.Add(fruit_cup);
                    break;
                case 4:
                    Order.Add("No Dessert");
                    totalCalolries.Add(no_dessert);
                    break;
                default:
                    Order.Add("No Side");
                    totalCalolries.Add(no_side);
                    break;
            }

            int caloriCount = 0;

            foreach (var items in totalCalolries)
            {
                caloriCount = caloriCount + items;
            }

            return "Your Calorie Count is " + caloriCount;
        }
    }
}

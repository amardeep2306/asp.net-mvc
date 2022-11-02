using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace asp.net_mvc.Controllers
{
    public class WebApiController : ApiController
    {
        // GET api/webapi
        public double Get(double firstNumber, double secondNumber, string action = "Add")
        {
            double result = 0;
            double num1 = Convert.ToDouble(firstNumber);
            double num2 = Convert.ToDouble(secondNumber);
            result = num1 + num2;
            action = action.ToLower();
            if (action == "substract")
            {
                result = num1 - num2;
            } else if(action == "multiply")
            {
                result = num1 * num2;
            }


            return result;
        }
    }
}

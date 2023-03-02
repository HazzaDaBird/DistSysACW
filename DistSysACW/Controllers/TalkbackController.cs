using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DistSysACW.Controllers
{
    public class UserController : BaseController
    {
        /// <summary>
        /// Constructs a TalkBack controller, taking the UserContext through dependency injection
        /// </summary>
        /// <param name="context">DbContext set as a service in Startup.cs and dependency injected</param>
        public UserController(Models.UserContext context) : base(context) { }


        [ActionName("Hello")]
        public string Get()
        {
            #region TASK1
            // TODO: add api/talkback/hello response
            #endregion
            string hello = "hello world";
            return hello;

        }

        [ActionName("Sort")]
        public IActionResult Get([FromQuery]int[] integers)
        {
            #region TASK1
            // TODO: 
            // sort the integers into ascending order
            // send the integers back as the api/talkback/sort response
            #endregion
            //Array.Sort(integers);
            //string sortedint = string.Join(",", integers);
            //return Ok("[" + sortedint + "]");
            try
            {
                Array.Sort(integers);
                string sortedint = string.Join(",", integers);
                return Ok("[" + sortedint + "]");
            }
            catch (InvalidCastException)
            {
                return BadRequest("Bad Request");
            }
        }

    }
}

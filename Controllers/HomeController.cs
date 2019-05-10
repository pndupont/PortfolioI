    using Microsoft.AspNetCore.Mvc;
    namespace PORTFOLIOI.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public string Index()
            {
                return "This is my index page";
            }
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("projects")]     //associated route string (exclude the leading /)
            public string Project()
            {
                return "These are my projects";
            }
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("contact")]     //associated route string (exclude the leading /)
            public string Contact()
            {
                return "This is my contact info";
            }
        }

    }

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "index method";
        }

        public string test()
        {
            return "test method";
        }
    }
}

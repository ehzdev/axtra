using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Axtra.Web.Controllers
{
    public class ServicesController : Controller
    {
        [Route("services", Name ="ServicesIndex_En")]
        [Route("servicios", Name ="ServicesIndex_Es")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
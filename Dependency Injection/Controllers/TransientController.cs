using Dependency_Injection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Controllers
{
    public class TransientController : Controller
    {
        private ITransient1 transient1;
        private ITransient2 transient2;

        public TransientController(ITransient1 transient1, ITransient2 transient2)
        {
            this.transient1 = transient1;
            this.transient2 = transient2;
        }

        public IActionResult Index()
        {
            int value=transient1.GetInctanseCount();
            return View(value);
        }
    }
}

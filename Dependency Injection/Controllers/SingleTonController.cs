using Dependency_Injection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Controllers
{
    public class SingleTonController : Controller
    {
        private ISingleTon _singleTon;

        public SingleTonController(ISingleTon singleTon)
        {
            _singleTon = singleTon;
        }

        public IActionResult Index()
        {
            int value = _singleTon.GetInctanseCount();
            return View(value);
        }
    }
}

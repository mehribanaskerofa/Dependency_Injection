using Dependency_Injection.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Controllers
{
    public class ScopedController : Controller
    {
        private IScoped1 _scoped1;
        private IScoped2 _scoped2;

        public ScopedController(IScoped1 scoped1, IScoped2 scoped2)
        {
            _scoped1 = scoped1;
            _scoped2 = scoped2;
        }

        public IActionResult Index()
        {
           int value= _scoped1.GetInctanseCount();
            return View(value);
        }
    }
}

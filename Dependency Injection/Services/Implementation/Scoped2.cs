using Dependency_Injection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Services.Implementation
{
    public class Scoped2:IScoped2
    {
        private IScoped1 _scoped1;

        public Scoped2(IScoped1 scoped1)
        {
            _scoped1 = scoped1;
        }
    }
}

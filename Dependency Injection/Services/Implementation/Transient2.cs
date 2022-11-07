using Dependency_Injection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Services.Implementation
{
    public class Transient2:ITransient2
    {
        //private static int Inscounter = 0;
        private ITransient1 _transient1;

        public Transient2(ITransient1 transient1)
        {
            _transient1 = transient1;
            // Inscounter++;
        }

        //public int GetInctanseCount()
        //{
        //    return Inscounter;
        //}
    }
}

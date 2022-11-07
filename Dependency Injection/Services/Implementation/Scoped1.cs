using Dependency_Injection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Services.Implementation
{
    public class Scoped1 : IScoped1
    {
        /* Scoped service - Refresh vaxti,(classi bildiren) interface her class constructorunda cagrildiqda,
         * her bir yazildigi class ucun eyni interfaceni istifade edir. 
         */

        private static int insCounter = 0;
        public Scoped1()
        {
            insCounter++;
        }
        public int GetInctanseCount()
        {
            return insCounter;
        }
    }
}

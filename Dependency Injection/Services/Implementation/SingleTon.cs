using Dependency_Injection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Services.Implementation
{
    public class SingleTon : ISingleTon
    {
        /*  proyekt ilk isleyen vaxt Startupda iSingleTon basa dusurki 
         *  iSingleTon SingleTon classinin instancesini(1 object) 1 defe yaradir ve 
         *  butun proyekt boyu her yerde proyekt baglanana qeder(refresh olsa bele eynisini) istifade edir.
        */

        private static int instanceCounter = 0;
        public SingleTon()
        {
            instanceCounter++;
        }
        public int GetInctanseCount()
        {
            return instanceCounter;
        }
    }
}

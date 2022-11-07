using Dependency_Injection.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_Injection.Services.Implementation
{
    public class Transient1 : ITransient1
    {
        /*  Transient service - proyekt run olanda, Startupda interface Transient teyin olunduguna gore, 
         *  her bir refreshde, her classin constructoru yeni (interface->class)obyect yaradir.
         *  Yeni her cagrilan(refresh) interface(ITransient1, ITransient2) ozune aid olan yeni class(Transient1 ve Transient2 class) objecti yaradir.
         */


        // classin nece defe cagrildigini yoxlamaq ucun Inscounter yaradilir ve constructorda gosterilir.
        private static int Inscounter=0;
        public Transient1()
        {
            Inscounter++;
        }
        public int GetInctanseCount()
        {
            return Inscounter;
        }
    }
}

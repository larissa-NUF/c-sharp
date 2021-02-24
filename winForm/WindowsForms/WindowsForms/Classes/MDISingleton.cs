using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    public class MDISingleton
    {
        private MDISingleton () { }

        private static MDIParentPrincipal inst;
        public static MDIParentPrincipal InstSingleton()
        {
            if (inst == null)
            {
                inst = new MDIParentPrincipal();
                return inst;
            }
            return inst;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15_09_Lombard.Model;

namespace _15_09_Lombard.Model
{
    class ConnectOdb
    {
        public static LombardEntities lEnt;
        public static LombardEntities GetContext()
        {
            if (lEnt == null) lEnt = new LombardEntities();
            return lEnt;
        }
    }
}

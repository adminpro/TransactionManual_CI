using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class ServiceInfoEnDB : BaseDB<SERVICEINFO>
    {
        public ServiceInfoEnDB()
            : base(@"RDB\SERVICEINFO.EN")
        {

        }
    }
}

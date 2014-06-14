using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class ServiceInfoCsDB : BaseDB<SERVICEINFO>
    {
        public ServiceInfoCsDB()
            : base(@"RDB\SERVICEINFO.CS")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class ServiceInfoEtDB : BaseDB<SERVICEINFO>
    {
        public ServiceInfoEtDB()
            : base(@"RDB\SERVICEINFO.ET")
        {

        }
    }
}

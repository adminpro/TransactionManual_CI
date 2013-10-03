using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class ServiceInfoEnDB : BaseDB<SERVICEINFO_EN>
    {
        public ServiceInfoEnDB()
            : base(@"RDB\SERVICEINFO.EN")
        {

        }
    }
}

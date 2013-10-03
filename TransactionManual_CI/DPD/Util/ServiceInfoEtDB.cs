using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class ServiceInfoEtDB:BaseDB<SERVICEINFO_ET>
    {
        public ServiceInfoEtDB()
            : base(@"RDB\SERVICEINFO.ET")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class ServiceInfoDeDB : BaseDB<SERVICEINFO_DE>
    {
        public ServiceInfoDeDB()
            : base(@"RDB\SERVICEINFO.DE")
        {

        }
    }
}

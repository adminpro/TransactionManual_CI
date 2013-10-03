using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class ServicesInfoCsDB : BaseDB<SERVICEINFO_CS>
    {
        public ServicesInfoCsDB()
            : base(@"RDB\SERVICEINFO.CS")
        {

        }
    }
}

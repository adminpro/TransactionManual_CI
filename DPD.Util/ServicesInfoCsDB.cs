using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class ServicesInfoCsDB : BaseDB<SERVICEINFO>
    {
        public ServicesInfoCsDB()
            : base(@"RDB\SERVICEINFO.CS")
        {

        }
    }
}

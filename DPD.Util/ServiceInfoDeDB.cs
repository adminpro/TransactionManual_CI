using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class ServiceInfoDeDB : BaseDB<SERVICEINFO>
    {
        public ServiceInfoDeDB()
            : base(@"RDB\SERVICEINFO.DE")
        {

        }
    }
}

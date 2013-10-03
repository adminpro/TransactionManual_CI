using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class LocationEnDB : BaseDB<LOCATION_EN>
    {
        public LocationEnDB()
            : base(@"RDB\LOCATION.EN")
        {

        }
    }
}

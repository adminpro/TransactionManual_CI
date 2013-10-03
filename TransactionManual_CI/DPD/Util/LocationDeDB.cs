using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class LocationDeDB : BaseDB<LOCATION_DE>
    {
        public LocationDeDB()
            : base(@"RDB\LOCATION.DE")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class LocationFrDB : BaseDB<LOCATION_FR>
    {
        public LocationFrDB()
            : base(@"RDB\LOCATION.FR")
        {

        }
    }
}

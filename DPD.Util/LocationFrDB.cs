using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class LocationFrDB : BaseDB<LOCATION>
    {
        public LocationFrDB()
            : base(@"RDB\LOCATION.FR")
        {

        }
    }
}

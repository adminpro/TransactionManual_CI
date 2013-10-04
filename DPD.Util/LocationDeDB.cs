using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class LocationDeDB : BaseDB<LOCATION>
    {
        public LocationDeDB()
            : base(@"RDB\LOCATION.DE")
        {

        }
    }
}

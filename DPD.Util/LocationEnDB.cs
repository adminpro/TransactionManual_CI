using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class LocationEnDB : BaseDB<LOCATION>
    {
        public LocationEnDB()
            : base(@"RDB\LOCATION.EN")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class CountryDB : BaseDB<COUNTRY>
    {
        public CountryDB()
            : base(@"RDB\COUNTRY")
        {

        }
    }
}

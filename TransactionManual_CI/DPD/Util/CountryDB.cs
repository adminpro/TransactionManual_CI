using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class CountryDB : BaseDB<COUNTRY>
    {
        public CountryDB()
            : base(@"RDB\COUNTRY")
        {

        }
    }
}

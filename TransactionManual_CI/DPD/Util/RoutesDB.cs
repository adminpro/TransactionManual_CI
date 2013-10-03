using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class RoutesDB : BaseDB<ROUTES>
    {
        public RoutesDB()
            : base(@"RDB\ROUTES")
        {

        }
    }
}

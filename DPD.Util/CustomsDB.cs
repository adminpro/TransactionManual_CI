using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class CustomsDB : BaseDB<CUSTOMS>
    {
        public CustomsDB()
            : base(@"RDB\CUSTOMS")
        {

        }
    }
}

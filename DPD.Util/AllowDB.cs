using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class AllowDB:BaseDB<ALLOW>
    {
        public AllowDB()
            : base(@"RDB\ALLOW")
        {

        }
    }
}

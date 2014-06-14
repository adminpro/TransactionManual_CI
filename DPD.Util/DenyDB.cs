using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class DenyDB:BaseDB<DENY>
    {
        public DenyDB()
            : base(@"RDB\DENY")
        {

        }
    }
}

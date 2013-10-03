using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class DepotsDB:BaseDB<DEPOTS>
    {
        public DepotsDB():base(@"RDB\DEPOTS")
        {

        }
    }
}

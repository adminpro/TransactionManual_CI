using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class ServiceDB : BaseDB<SERVICE>
    {
        public ServiceDB()
            : base(@"RDB\SERVICE")
        {

        }
    }
}

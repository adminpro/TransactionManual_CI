using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class DepotsDB:BaseDB<DEPOTS>
    {
        public DepotsDB():base(@"RDB\DEPOTS")
        {

        }

        protected override DEPOTS GetItem(string line)
        {
            string[] arr = line.Split(new char[] { '|' });
            return new DEPOTS
            {
                GeoPostDepotNumber = arr[0],
                IATALikeCode = arr[1],
                GroupID = arr[2],
                Name1 = arr[3],
                Name2 = arr[4],
                Address1 = arr[5],
                Address2 = arr[6],
                PostCode = arr[7],
                CityName = arr[8],
                ISO_Alpha2CountryCode = arr[9],
                Phone = arr[10],
                Fax = arr[11],
                Mail = arr[12],
                WEB = arr[13]
            };
            //return base.GetItem(line);
        }
    }
}

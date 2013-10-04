using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
{
    public class RoutesDB : BaseDB<ROUTES>
    {
        public RoutesDB()
            : base(@"RDB\ROUTES")
        {

        }
        /// <summary>
        /// Gets the item.
        /// Apply for get large data.
        /// </summary>
        /// <param name="line">The line data.</param>
        /// <returns></returns>
        protected override ROUTES GetItem(string line)
        {
            string[] arr = line.Split(new char[] { '|' });
            return new ROUTES
            {
                DestinationCountry = arr[0],
                BeginPostCode = arr[1],
                EndPostCode = arr[2],
                ServiceCodes = arr[3],
                RoutingPlaces = arr[4],
                SendingDate = arr[5],
                O_Sort = arr[6],
                D_Depot = arr[7],
                GroupingPriority = arr[8],
                D_Sort = arr[9],
                BarcodeID = arr[10]
            };
            //return base.GetItem(line);
        }
    }
}

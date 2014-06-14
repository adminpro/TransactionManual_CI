using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace DPD.Util
{
    public class RoutesDB : BaseDB<ROUTES>
    {
        public RoutesDB()
            : base(@"RDB\ROUTES")
        {

        }

        private bool CompareTwoChar(char one, char two, char three, char four)
        {
            return one == two && three == four;
        }
        private bool CompareCountryCode(string a, string b)
        {
            return a == b;
        }
        public RoutesDB(string countryCode)
            : base()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            this.Lists = new List<ROUTES>();
            string tmpLine = string.Empty;
            bool matchFind = false;

            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", @"RDB\ROUTES")))
            {
                for (int i = 0; i < 7; i++)
                {
                    reader.ReadLine();
                }
                while (!reader.EndOfStream)
                {
                    tmpLine = reader.ReadLine();
                    if (matchFind)
                    {
                        //if (CompareTwoChar(tmpLine[0], countryCode[0], tmpLine[1], countryCode[1]))
                        //if(CompareCountryCode(tmpLine.Substring(0,2), countryCode))
                        //if (tmpLine.IndexOf(countryCode)==0)
                        if(tmpLine[0]==countryCode[0] && tmpLine[1]==countryCode[1])
                            //GetItem(tmpLine);
                            this.Lists.Add(GetItem(tmpLine));
                        else
                            break;

                    }
                    else
                    {
                        //if (CompareTwoChar(tmpLine[0], countryCode[0], tmpLine[1], countryCode[1]))
                        //if (CompareCountryCode(tmpLine.Substring(0, 2), countryCode))
                        //if (tmpLine.IndexOf(countryCode) == 0)
                        if (tmpLine[0] == countryCode[0] && tmpLine[1] == countryCode[1])
                        {
                            matchFind = true;
                            //GetItem(tmpLine);
                            this.Lists.Add(GetItem(tmpLine));
                        }
                        //else
                        //    continue;
                    }
                }
            }
            sw.Stop();
            System.Diagnostics.Trace.WriteLine(sw.ElapsedMilliseconds);
        }

        /// <summary>
        /// Gets the item.
        /// Apply for get large data.
        /// </summary>
        /// <param name="line">The line data.</param>
        /// <returns></returns>
        protected override ROUTES GetItem(string line)
        {
            string[] arr = line.Split(CharSpliter);
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

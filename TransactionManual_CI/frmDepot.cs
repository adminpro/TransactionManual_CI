using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using TransactionManual_CI.DPD.Util;

namespace TransactionManual_CI
{
    public partial class frmDepot : Form
    {
        public frmDepot()
        {
            InitializeComponent();
        }

        private void brfChooseRDB_ChoosedFile(object sender, CodeGenerator.OnChoosedFileEventArg e)
        {
            DepotsDB depotsDB = new DepotsDB();

            //List<DEPOTS> depotDB = (from c in System.IO.File.ReadAllLines(e.FilePath)
            //                        where !c.StartsWith("#")
            //                        select GetDepotItem(c)).ToList();

        }

        public DEPOTS GetDepotItem(string line)
        {
            string[] arr = line.Split(new string[] { "|" }, StringSplitOptions.None);
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
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;
using System.IO;
using TrackingEngine.BLL.Repository;

namespace TransactionManual_CI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lsvTransact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTransact.SelectedItems != null)
            {

            }
        }

        private void btnParseDate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
            DateTime dt = DateTime.ParseExact(txtDateTime.Text, @"M/dd/yyyy h:mm:ss tt", null);
            string test = dt.ToString();
            MessageBox.Show(test);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            XDocument xdoc = XDocument.Load("Aramex_201309260601.xml");
            var output = xdoc.Descendants("Name").Select(c => "<File>" + c.Value + "</File>");
            result = string.Join(Environment.NewLine, output.ToArray());
            XDocument xdoc1 = XDocument.Load("Asendia_201309260601.xml");
            var output1 = xdoc1.Descendants("Name").Select(c => "<File>" + c.Value + "</File>");
            result = string.Join(Environment.NewLine, output.ToArray());
        }

        private void btnSetCarrierId_Click(object sender, EventArgs e)
        {
            ShipmentRepository shipRepo = new ShipmentRepository();
            var allShipmentsNull = shipRepo.SelectAll(c => c.CarrierReference == null).ToList();

            string partern = "Asendia_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReference").Value));
            }
            allCR = allCR.Distinct().ToList();
            int iCount = 0;
            foreach (var shipment in allShipmentsNull)
            {
                iCount++;
                //if (allCR.IndexOf(shipment.CustomerReference) > 0)
                //    shipment.CarrierId = 8;
            }
            //shipRepo.SubmitChanges();
        }

        FileInfo[] GetAllFiles(string partern)
        {
            DirectoryInfo di = new DirectoryInfo("Log");
            return di.GetFiles(partern, SearchOption.AllDirectories);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partern = "Asendia_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
        }

        private void btnAramex_Click(object sender, EventArgs e)
        {
            string partern = "Aramex_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReferenceNo").Value));
            }
            allCR = allCR.Distinct().ToList();
            MessageBox.Show(allCR.Count.ToString());
        }

        private void btnDHL_Click(object sender, EventArgs e)
        {
            string partern = "DHL_*.xml";
            FileInfo[] listAsendiaFiles = GetAllFiles(partern);
            List<string> allCR = new List<string>();
            for (int i = 0; i < listAsendiaFiles.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listAsendiaFiles[i].FullName).Descendants("Item").Select(c => c.Attribute("CarrierReference").Value));
            }
            allCR = allCR.Distinct().ToList();
            MessageBox.Show(allCR.Count.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listFindMax = GetAllFiles(@"D:\Config\Projects\Carrier_New\FTP_DHL\Aramex\20130927", "*.xml");
            List<string> allCR = new List<string>();
            for (int i = 0; i < listFindMax.Length; i++)
            {
                allCR.AddRange(XDocument.Load(listFindMax[i].FullName).Descendants("HAWBUpdate").Select(c => c.Element("Comment1").Value + c.Element("Comment2").Value ));
                if (allCR.Any(c => c.Length == 117))
                {
                }
            }

            
        }

        FileInfo[] GetAllFiles(string folder, string partern)
        {
            DirectoryInfo di = new DirectoryInfo(folder);
            return di.GetFiles(partern, SearchOption.AllDirectories);
        }
    }
}

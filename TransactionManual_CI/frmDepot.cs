using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DPD.Util;
using System.Diagnostics;
using System.IO;
using System.Drawing.Imaging;

namespace TransactionManual_CI
{
    public partial class frmDepot : Form
    {
        public List<ROUTES> Lists { get; set; }

        public frmDepot()
        {
            InitializeComponent();
        }

        //private void brfChooseRDB_ChoosedFile(object sender, CodeGenerator.OnChoosedFileEventArg e)
        //{
        //    DepotsDB depotsDB = new DepotsDB();

        //    //List<DEPOTS> depotDB = (from c in System.IO.File.ReadAllLines(e.FilePath)
        //    //                        where !c.StartsWith("#")
        //    //                        select GetDepotItem(c)).ToList();

        //}

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

        private void cboRDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            switch (cboRDB.Text)
            {
                case "COUNTRY":
                    CountryDB countryDB = new CountryDB();
                    dgvData.DataSource = countryDB.Lists;
                    break;
                case "DEPOTS":
                    DepotsDB depotsDB = new DepotsDB();
                    dgvData.DataSource = depotsDB.Lists;
                    break;
                case "LOCATION_DE":
                    LocationDeDB locationDeDB = new LocationDeDB();
                    dgvData.DataSource = locationDeDB.Lists;
                    break;
                case "LOCATION_EN":
                    LocationEnDB locationEnDB = new LocationEnDB();
                    dgvData.DataSource = locationEnDB.Lists;
                    break;
                case "LOCATION_FR":
                    LocationFrDB locationFrDB = new LocationFrDB();
                    dgvData.DataSource = locationFrDB.Lists;
                    break;
                case "ROUTES":
                    if (this.Lists == null)
                    {
                        RoutesDB routesDB = new RoutesDB();
                        this.Lists = routesDB.Lists;
                    }
                    dgvData.DataSource = this.Lists;
                    break;
                case "SERVICE":
                    ServiceDB ServiceDB = new ServiceDB();
                    dgvData.DataSource = ServiceDB.Lists;
                    break;
                case "SERVICEINFO_CS":
                    ServicesInfoCsDB servicesInfoCsDB = new ServicesInfoCsDB();
                    dgvData.DataSource = servicesInfoCsDB.Lists;
                    break;
                case "SERVICEINFO_DE":
                    ServiceInfoDeDB serviceInfoDeDB = new ServiceInfoDeDB();
                    dgvData.DataSource = serviceInfoDeDB.Lists;
                    break;
                case "SERVICEINFO_EN":
                    ServiceInfoEnDB serviceInfoEnDB = new ServiceInfoEnDB();
                    dgvData.DataSource = serviceInfoEnDB.Lists;
                    break;
                case "SERVICEINFO_ET":
                    ServiceInfoEtDB serviceInfoEtDB = new ServiceInfoEtDB();
                    dgvData.DataSource = serviceInfoEtDB.Lists;
                    break;
            }
            stopWatch.Stop();
            lblTotal.Text = string.Format("Total: {0} record, {1} field. Elapsed: {2} milliseconds.", dgvData.RowCount, dgvData.ColumnCount, stopWatch.ElapsedMilliseconds);
        }

        private void imageToBase64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Filter = "Image file (.png, .jpg, .gif, .bmp)|*.png; *.jpg; *.gif; *.bmp";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    Clipboard.SetText(ImageToBase64(Image.FromFile(openDlg.FileName), this.GetImageType(openDlg.FileName)));
                }
                MessageBox.Show("Export image to base64 has been copy to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void base64ToImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDlg = new SaveFileDialog();
                saveDlg.Filter = "Image file (.png, .jpg, .gif, .bmp)|*.png; *.jpg; *.gif; *.bmp";
                if (saveDlg.ShowDialog() == DialogResult.OK)
                {
                    Base64ToImage(Clipboard.GetText()).Save(saveDlg.FileName, GetImageType(saveDlg.FileName));
                }
                MessageBox.Show("Export base64 to image success.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); ;
            }
        }

        private void imageToBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Filter = "Image file (.png, .jpg, .gif, .bmp)|*.png; *.jpg; *.gif; *.bmp";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    Clipboard.SetText(ImageToBinary(Image.FromFile(openDlg.FileName), this.GetImageType(openDlg.FileName)));
                }
                MessageBox.Show("Export image to binary has been copy to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void imageToHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDlg = new OpenFileDialog();
                openDlg.Filter = "Image file (.png, .jpg, .gif, .bmp)|*.png; *.jpg; *.gif; *.bmp";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    Clipboard.SetText(ImageToHex(Image.FromFile(openDlg.FileName), this.GetImageType(openDlg.FileName)));
                }
                MessageBox.Show("Export image to hex has been copy to clipboard.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private ImageFormat GetImageType(string fileName)
        {
            string ext = string.Empty;
            int currentDot = fileName.LastIndexOf(".");
            if (currentDot < fileName.Length)
                ext = fileName.Substring(currentDot);
            switch (ext.ToLower())
            {
                case ".png":
                    return ImageFormat.Png;
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".gif":
                    return ImageFormat.Gif;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
            }
            //Default
            return ImageFormat.Png;
        }

        public string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public string ImageToHex(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                return Bytes2HexString(imageBytes);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public string ImageToBinary(Image image, ImageFormat format)
        {
            Bitmap img = new Bitmap(image);
            string texto = string.Empty;
            //for (int i = 0; i < image.Height; i++)
            //{
            //    for (int j = 0; j < image.Width; j++)
            //    {
            //        if (img.GetPixel(j, i).A.ToString() == "255" && img.GetPixel(j, i).B.ToString() == "255" && img.GetPixel(j, i).G.ToString() == "255" && img.GetPixel(j, i).R.ToString() == "255")
            //        {
            //            texto = texto + "O";
            //        }
            //        else
            //        {
            //            texto = texto + "X";
            //        }
            //    }
            //    texto+=Environment.NewLine;
            //}
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (img.GetPixel(i, j).A.ToString() == "255" && img.GetPixel(i, j).B.ToString() == "255" && img.GetPixel(i, j).G.ToString() == "255" && img.GetPixel(i, j).R.ToString() == "255")
                    {
                        texto = texto + "0";
                    }
                    else
                    {
                        texto = texto + "1";
                    }
                }
            }
            return texto;
        }

        private byte[] HexString2Bytes(string hexString)
        {
            int bytesCount = (hexString.Length) / 2;
            byte[] bytes = new byte[bytesCount];
            for (int x = 0; x < bytesCount; ++x)
            {
                bytes[x] = Convert.ToByte(hexString.Substring(x * 2, 2), 16);
            }

            return bytes;
        }

        private string Bytes2HexString(byte[] buffer)
        {
            var hex = new StringBuilder(buffer.Length * 2);
            foreach (byte b in buffer)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}

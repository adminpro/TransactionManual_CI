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
using System.Runtime.InteropServices;
using TransactionManual_CI.Common;

namespace TransactionManual_CI
{
    public partial class frmDepot : Form
    {
        public List<ROUTES> Lists { get; set; }

        public frmDepot()
        {

            DateTime dt = DateTime.Parse("2005/06/14");
            
            //string a = "15191";
            //string b = "15619";
            //string c = "15618";

            //var output1 = string.Compare(c, a);
            //output1 = string.Compare(c, b);

            CheckDigitCalculation checkDig = new CheckDigitCalculation();
            var output = checkDig.Get_Iso7064_Mod37_36("007110601632532948375179276".ToCharArray()); //ABC987

            InitializeComponent();

            //var testGetString = AppResource.ResourceManager.GetString("Zara_Template");
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
                        RoutesDB routesDB = new RoutesDB(); //ZW "FR"
                        this.Lists = routesDB.Lists;
                    }
                    dgvData.DataSource = this.Lists;
                    break;
                case "SERVICE":
                    ServiceDB serviceDB = new ServiceDB();
                    dgvData.DataSource = serviceDB.Lists;
                    break;
                case "SERVICEINFO_CS":
                    ServiceInfoCsDB serviceInfoCsDB = new ServiceInfoCsDB();
                    dgvData.DataSource = serviceInfoCsDB.Lists;
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
                case "ALLOW":
                    AllowDB allowDB = new AllowDB();
                    dgvData.DataSource = allowDB.Lists;
                    break;
                case "DENY":
                    DenyDB denyDB = new DenyDB();
                    dgvData.DataSource = denyDB.Lists;
                    break;
                case "CUSTOMS":
                    CustomsDB customsDB = new CustomsDB();
                    dgvData.DataSource = customsDB.Lists;
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

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
        private PictureBox pictureBox1 = new PictureBox();
        private PictureBox pictureBox2 = new PictureBox();
        private Bitmap bm;
        private void imageTo1bppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load a file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files|*.bmp;*.gif;*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = (Bitmap)Image.FromFile(dlg.FileName);
                //Ensure that it's a 32 bit per pixel file
                if (img.PixelFormat != PixelFormat.Format32bppPArgb)
                {
                    Bitmap temp = new Bitmap(img.Width, img.Height, PixelFormat.Format32bppPArgb);
                    Graphics g = Graphics.FromImage(temp);
                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);
                    img.Dispose();
                    g.Dispose();
                    img = temp;
                }
                this.pictureBox1.Image = img;
                //lock the bits of the original bitmap
                BitmapData bmdo = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, img.PixelFormat);

                //and the new 1bpp bitmap
                bm = new Bitmap(this.pictureBox1.Image.Width, this.pictureBox1.Image.Height, PixelFormat.Format1bppIndexed);
                BitmapData bmdn = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);

                //for diagnostics
                DateTime dt = DateTime.Now;

                //scan through the pixels Y by X
                int x, y;
                for (y = 0; y < img.Height; y++)
                {
                    for (x = 0; x < img.Width; x++)
                    {
                        //generate the address of the colour pixel
                        int index = y * bmdo.Stride + (x * 4);
                        //check its brightness
                        if (Color.FromArgb(Marshal.ReadByte(bmdo.Scan0, index + 2),
                                        Marshal.ReadByte(bmdo.Scan0, index + 1),
                                        Marshal.ReadByte(bmdo.Scan0, index)).GetBrightness() > 0.5f)
                            this.SetIndexedPixel(x, y, bmdn, true); //set it if its bright.
                    }
                }

                //tidy up
                bm.UnlockBits(bmdn);
                img.UnlockBits(bmdo);

                //show the time taken to do the conversion
                TimeSpan ts = dt - DateTime.Now;
                System.Diagnostics.Trace.WriteLine("Conversion time was:" + ts.ToString());

                //display the 1bpp image.
                this.pictureBox2.Image = bm;

                bm.Save("C:\\test_selektvarcht.jpg", ImageFormat.Jpeg);

            }
        }
        protected void SetIndexedPixel(int x, int y, BitmapData bmd, bool pixel)
        {
            int index = y * bmd.Stride + (x >> 3);
            byte p = Marshal.ReadByte(bmd.Scan0, index);
            byte mask = (byte)(0x80 >> (x & 0x7));
            if (pixel)
                p |= mask;
            else
                p &= (byte)(mask ^ 0xff);
            Marshal.WriteByte(bmd.Scan0, index, p);
        }

        private void convertTo1bppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files|*.bmp;*.gif;*.jpg;*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Bitmap b = new System.Drawing.Bitmap(dlg.FileName);
                ImageTo1BPP.SplashImage(b, 0, 0);
                //
                DateTime dtFaq = DateTime.Now;
                System.Drawing.Bitmap b0 = ImageTo1BPP.CopyToBpp(b, 1);
                b0.Save("C:\\test_1bpp_colisimo.jpg", ImageFormat.Jpeg);

                TimeSpan tsFaq = DateTime.Now - dtFaq;
                Console.WriteLine("GDI conversion time: " + tsFaq.ToString());
                ImageTo1BPP.SplashImage(b0, 200, 100);
                //
                DateTime dtLu = DateTime.Now;
                System.Drawing.Bitmap b1 = ImageTo1BPP.FaqCopyTo1bpp(b);
                TimeSpan tsLu = DateTime.Now - dtLu;
                Console.WriteLine("FAQ conversion time: " + tsLu.ToString());
                ImageTo1BPP.SplashImage(b1, 400, 200);
                //
                System.Threading.Thread.Sleep(1000);
                ImageTo1BPP.InvalidateRect(IntPtr.Zero, IntPtr.Zero, 1);
            }
        }
    }
}

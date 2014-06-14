using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace DPD.Util
{
    public class SelektVrachtDB
    {
        public List<SelektVracht> Lists { get; set; }

        public SelektVrachtDB(string dataFolder)
        {
            if (this.Lists == null)
                this.Lists = new List<SelektVracht>();
            string fullDataFolder = Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dataFolder);
            if (Directory.Exists(fullDataFolder))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullDataFolder);
                FileInfo[] listDataFile = dirInfo.GetFiles("*.txt", SearchOption.TopDirectoryOnly);
                SelektVracht selektVracht = null;
                SelektVrachtItem selektVrachtItem = null;
                for (int i = 0; i < listDataFile.Length; i++)
                {
                    selektVracht = new SelektVracht();
                    using (StreamReader reader = listDataFile[i].OpenText())
                    {
                        while (reader.Peek() > 0)
                        {
                            string line = reader.ReadLine();
                            switch (line.Substring(0, 4))
                            {
                                //ConsignorId
                                case "A030":
                                    selektVracht.ConsignorId = line.Substring(4).Trim();
                                    break;
                                //ConsignorNumber
                                case "V800":
                                    selektVrachtItem.ConsignorNumber = line.Substring(4).Trim();
                                    break;
                                //DateCreated
                                case "V012":
                                    selektVrachtItem.DateCreated = line.Substring(4).Trim();
                                    break;
                                //ParcelNumber
                                case "V020":
                                    selektVrachtItem.ParcelNumber = line.Substring(4).Trim();
                                    break;
                                //CashOnDelivery
                                case "V070":
                                    selektVrachtItem.CashOnDelivery = line.Substring(4).Trim();
                                    break;
                                //CustomerReference
                                case "V160":
                                    selektVrachtItem.CustomerReference = line.Substring(4).Trim();
                                    break;
                                //HouseNumber
                                case "V180":
                                    selektVrachtItem.HouseNumber = line.Substring(4).Trim();
                                    break;
                                //DeliveryAddress
                                case "V181":
                                    selektVrachtItem.DeliveryAddress = line.Substring(4).Trim();
                                    break;
                                //PostCode
                                case "V190":
                                    selektVrachtItem.PostCode = line.Substring(4).Trim();
                                    break;
                                //TypeOfOrder
                                case "V011":
                                    selektVrachtItem.TypeOfOrder = line.Substring(4).Trim();
                                    break;
                                //Start repeat
                                case "V010":
                                    selektVrachtItem = new SelektVrachtItem();
                                    break;
                                //End repeat
                                case "V999":
                                    selektVracht.ListParcel.Add(selektVrachtItem);
                                    break;
                                //End of file
                                case "Z999":
                                    break;
                            } //End switch case
                        } //End while
                    } //End using StreamReader
                    this.Lists.Add(selektVracht);
                } //End for
            }
            else
                throw new Exception("Folder does not exists.");
        }
    }
}

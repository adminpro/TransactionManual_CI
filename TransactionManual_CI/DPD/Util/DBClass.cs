using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransactionManual_CI.DPD.Util
{
    public class COUNTRY
    {
        public string ISO_NumCountryCode { get; set; }
        public string ISO_Alpha2CountryCode { get; set; }
        public string ISO_Alpha3CountryCode { get; set; }
        public string DestinationLanguages { get; set; }
        public string FlagPostCodeNo { get; set; }
    }

    public class DEPOTS
    {
        public string GeoPostDepotNumber { get; set; }
        public string IATALikeCode { get; set; }
        public string GroupID { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string CityName { get; set; }
        public string ISO_Alpha2CountryCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mail { get; set; }
        public string WEB { get; set; }
    }

    public class LOCATION_DE
    {
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public string ISO_Alpha2CountryCode { get; set; }
        public string PostCode { get; set; }
    }
    public class LOCATION_EN
    {

    }
    public class LOCATION_FR
    {

    }
    public class ROUTES
    {

    }
    public class SERVICE
    {

    }

    public class SERVICEINFO_CS
    {

    }
    public class SERVICEINFO_DE
    {

    }
    public class SERVICEINFO_EN
    {

    }
    public class SERVICEINFO_ET
    {

    }
}

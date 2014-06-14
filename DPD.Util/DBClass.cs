using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPD.Util
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

    public class LOCATION
    {
        public string AreaName { get; set; }
        public string CityName { get; set; }
        public string ISO_Alpha2CountryCode { get; set; }
        public string PostCode { get; set; }
    }
    public class ROUTES
    {
        public string DestinationCountry { get; set; }
        public string BeginPostCode { get; set; }
        public string EndPostCode { get; set; }
        public string ServiceCodes { get; set; }
        public string RoutingPlaces { get; set; }
        public string SendingDate { get; set; }
        public string O_Sort { get; set; }
        public string D_Depot { get; set; }
        public string GroupingPriority { get; set; }
        public string D_Sort { get; set; }
        public string BarcodeID { get; set; }
    }
    public class SERVICE
    {
        public string ServiceCode { get; set; }
        public string ServiceText { get; set; }
        public string ServiceMark { get; set; }
        public string ServiceElements { get; set; }
    }

    public class SERVICEINFO
    {
        public string ServiceCode { get; set; }
        public string ServiceFieldInfo { get; set; }
    }
    public class ALLOW
    {
        public string RuleFrom { get; set; }
        public string RuleService { get; set; }
        public string RuleTo { get; set; }
        public string UniqueAllowID { get; set; }
    }

    public class DENY
    {
        public string UniqueAllowID { get; set; }
        public string RuleFrom { get; set; }
        public string RuleService { get; set; }
        public string RuleTo { get; set; }
    }
    public class CUSTOMS
    {
        public string RuleFrom { get; set; }
        public string CustomsRouting { get; set; }
        public string RuleService { get; set; }
        public string RuleTo { get; set; }
        public string ISO_Alpha2CountryCode { get; set; }
        public string PostCode { get; set; }
    }
    /// <summary>
    /// Barcode_DataExchange5.4EN.pdf
    /// Page 19 Description detail
    /// </summary>
    public class SelektVracht
    {
        public SelektVracht()
        {
            if (this.ListParcel == null)
                this.ListParcel = new List<SelektVrachtItem>();
        }
        public string ConsignorId { get; set; } //A030
        public List<SelektVrachtItem> ListParcel { get; set; }
    }
    public class SelektVrachtItem
    {
        public string ConsignorNumber { get; set; } //V800
        public string DateCreated { get; set; } //V012
        public string ParcelNumber { get; set; } //V020
        public string CashOnDelivery { get; set; } //V070
        public string CustomerReference { get; set; } //V160
        public string HouseNumber { get; set; } //V180
        public string DeliveryAddress { get; set; } //V181
        public string PostCode { get; set; } //V190
        public string TypeOfOrder { get; set; } //V011: 1: Delivery order, 0: Collection order
    }
}

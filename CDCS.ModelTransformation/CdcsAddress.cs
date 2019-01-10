#region

using System;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "addresseAdres", IsNullable = false)]
    public class CdcsAddress {
        [XmlElement("ADRESNL")]
        public string Street_NL { get; set; }

        [XmlElement("ADRESFR")]
        public string Street_FR { get; set; }

        [XmlElement("ADNUM")]
        public string StreetNumber { get; set; }

        [XmlElement("BNUM")]
        public string PostalBox { get; set; }

        // [XmlElement("POSTNL")]
        // public string Postnl { get; set; }
        //
        // [XmlElement("POSTFR")]
        // public string Postfr { get; set; }

        [XmlElement("ZIP")]
        public string PostCode { get; set; }

        [XmlElement("GEMEENTE")]
        public string City_NL { get; set; }

        [XmlElement("COMMUNE")]
        public string City_FR { get; set; }

        [XmlElement("ADOPM")]
        public string Co_NL { get; set; }

        [XmlElement("ADREM")]
        public string Co_FR { get; set; }

        [XmlElement("WQ_CODE")]
        public string Monitoring_Code { get; set; }

        [XmlElement("WIJK")]
        public string MonitoringDistrict_NL { get; set; }

        [XmlElement("QUARTIER")]
        public string MonitoringDistrict_FR { get; set; }

        [XmlElement("STATCODE")]
        public string StatisticDistrict_Code { get; set; }

        [XmlElement("STATNMNL")]
        public string StatisticDistrict_NL { get; set; }

        [XmlElement("STATNMFR")]
        public string StatisticDistrict_FR { get; set; }

        [XmlElement("XCOORD")]
        public string X_Coord { get; set; }

        [XmlElement("YCOORD")]
        public string Y_Coord { get; set; }

        [XmlElement("WGS84LAT")]
        public string Latitude { get; set; }

        [XmlElement("WGS84LON")]
        public string Longitude { get; set; }
    }

}
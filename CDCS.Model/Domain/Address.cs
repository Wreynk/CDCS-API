#region

#endregion

#region

using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using TLT.BaseModel.Base;

#endregion

namespace CDCS.Model.Domain {

    [Owned]
    public class Address {
        public BilingualItem Co                     { get; set; }
        public string        StreetNumber           { get; set; }
        public BilingualItem Street                 { get; set; }
        public BilingualItem City                   { get; set; }
        public string        PostCode               { get; set; }
        public string        Monitoring_Code        { get; set; }
        public BilingualItem MonitoringDistrict     { get; set; }
        public string        StatisticDistrict_Code { get; set; }
        public BilingualItem StatisticDistrict      { get; set; }
        public double? Latitude               { get; set; }
        public double? Longitude              { get; set; }
        public string        PostalBox              { get; set; }
        public double?        X_Coord                { get; set; }
        public double? Y_Coord                { get; set; }

        [NotMapped]
        public string StreetAddress => $"{StreetNumber} {Street.InLocal}";

        [NotMapped]
        public string CityAddress => $"{PostCode} {City.InLocal}";
    }

}
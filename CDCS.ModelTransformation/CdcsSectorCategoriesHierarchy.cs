#region

using System;
using System.ComponentModel;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestRowCategoryAccess")]
    public class CdcsSectorCategoriesHierarchy : CdcsEntity {
        [XmlElement("level1")]
        public int? Topic1Id { get; set; }

        [XmlElement("orderLevel1")]
        public int Topic1_SortOrder { get; set; }

        [XmlElement("level2")]
        public int? Topic2Id { get; set; }

        [XmlElement("orderLevel2")]
        public int Topic2_SortOrder { get; set; }

        [XmlElement("level3")]
        public int? Topic3Id { get; set; }

        [XmlElement("orderLevel3")]
        public int Topic3_SortOrder { get; set; }

        [XmlElement("level4")]
        public int? Topic4Id { get; set; }

        [XmlElement("orderLevel4")]
        public int Topic4_SortOrder { get; set; }

        [XmlElement("sector")]
        public int SectorId { get; set; }

        [XmlElement("category")]
        public int CategoryId { get; set; }

        [XmlElement("orderCategory")]
        public int SortOrder { get; set; }
    }

}
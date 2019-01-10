#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation.Base {

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]

    // [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    [XmlRoot(ElementName = "updateRequest")]
    public class CdcsCategoriesInput {
        [XmlArray("sectorList")]
        [XmlArrayItem("sector", IsNullable = false)]
        public List<CdcsSector> CdcsSectors { get; set; }

        [XmlArray("levelList")]
        [XmlArrayItem("level", IsNullable = false)]
        public List<CdcsTopic> CdcsTopics { get; set; }

        [XmlArray("rowCategoryList")]
        [XmlArrayItem("rowCategory", IsNullable = false)]
        public List<CdcsCategory> CdcsCategories { get; set; }

        [XmlArray("rowCategoryAccessList")]
        [XmlArrayItem("rowCategoryAccess", IsNullable = false)]
        public List<CdcsSectorCategoriesHierarchy> CdcsSectorCategoriesHierarchies { get; set; }

        // [XmlAttribute]
        // [XmlIgnore]
        // public string schemaLocation { get; set; }
    }

}
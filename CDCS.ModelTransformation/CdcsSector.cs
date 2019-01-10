﻿#region

using System;
using System.ComponentModel;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestSector")]
    public class CdcsSector : CdcsEntity {
        [XmlElement("denomination")]
        public string Name_FR { get; set; }

        [XmlElement("benaming")]
        public string Name_NL { get; set; }

        [XmlElement("description")]
        public string Description_FR { get; set; }

        [XmlElement("beschrijving")]
        public string Description_NL { get; set; }

        [XmlElement("order")]
        public short SortOrder { get; set; }
    }

}
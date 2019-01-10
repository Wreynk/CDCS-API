#region

using System;
using System.ComponentModel;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestLevel")]
    public class CdcsTopic : CdcsEntity {
        [XmlElement("denomination")]
        public string Name_FR { get; set; }

        [XmlElement("benaming")]
        public string Name_NL { get; set; }
    }

}
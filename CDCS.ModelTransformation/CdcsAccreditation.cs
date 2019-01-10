#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestAgrementErken")]
    public class CdcsAccreditation : CdcsEntity {
        [XmlElement("value")]
        public List<CdcsTextItem> CdcsTextItems { get; set; }

        [XmlElement("pouvoirAgreantErkenning")]
        public string AccreditorId { get; set; }

        [XmlIgnore]
        [XmlElement("pouvoirAgreantErkenningSpecified")]
        public bool HasAccreditor { get; set; }
    }

}
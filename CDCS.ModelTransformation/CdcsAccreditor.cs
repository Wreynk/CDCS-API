#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestPouvoirAgreantErkenning")]
    public class CdcsAccreditor : CdcsEntity {
        [XmlElement("value")]
        public List<CdcsTextItem> CdcsTextItems { get; set; }
    }

}
#region

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using CDCS.ModelTransformation.Base;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "updateRequestLangStat")]
    public class CdcsOrganisationLanguage : CdcsEntity {
        [XmlElement("value")]
        public List<CdcsTextItem> CdcsTextItems { get; set; }
    }

}
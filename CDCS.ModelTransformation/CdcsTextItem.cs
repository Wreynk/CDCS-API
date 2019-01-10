#region

using System;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation {

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(ElementName   = "value", IsNullable = false)]
    public class CdcsTextItem {
        [XmlAttribute("i18n")]
        public string Language_Code { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
#region

using System.Xml.Serialization;

#endregion

namespace CDCS.Model {

    public class TextItem {
        [XmlAttribute("i18n")]
        public string Language_Code { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
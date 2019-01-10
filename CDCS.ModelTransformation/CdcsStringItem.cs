#region

using System;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot]
    public class CdcsStringItem
    {
        [XmlText]
        public string Text { get; set; }
    }

}
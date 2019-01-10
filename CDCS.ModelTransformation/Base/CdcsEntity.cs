#region

using System;
using System.Xml.Serialization;

#endregion

namespace CDCS.ModelTransformation.Base {

    [Serializable]
    [XmlType(AnonymousType = true)]
    public class CdcsEntity {
        [XmlElement("id")]
        public int Id { get; set; }
    }

}
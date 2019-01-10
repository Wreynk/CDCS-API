#region

#endregion

#region

using System.ComponentModel.DataAnnotations.Schema;
using CDCS.Model.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Accreditation : BaseEntity {
        public BilingualItem Name         { get; set; }
        public int           AccreditorId { get; set; }

        [NotMapped]
        public virtual Accreditor Accreditor { get; set; }
    }

}
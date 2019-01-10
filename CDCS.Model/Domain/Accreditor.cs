#region

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain
{

    public class Accreditor : BaseEntity
    {
        public BilingualItem Name { get; set; }

        [NotMapped]
        public virtual List<Accreditation> Accreditations { get; set; }
    }

}
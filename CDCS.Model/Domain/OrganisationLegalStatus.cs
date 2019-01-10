#region

using System.Collections.Generic;
using CDCS.Model.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain
{

    public class OrganisationLegalStatus : BaseEntity
    {
        public BilingualItem Name { get; set; }

        public virtual ICollection<Organisation> Organisations { get; set; }

    }

}
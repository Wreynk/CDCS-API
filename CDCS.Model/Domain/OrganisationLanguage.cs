#region

using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class OrganisationLanguage : BaseEntity {
        public BilingualItem Name { get; set; }
    }

}
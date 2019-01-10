#region

#endregion

#region

using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Language : BaseEntity {
        public BilingualItem Name { get; set; }
    }

}
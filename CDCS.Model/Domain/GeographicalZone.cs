#region

using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class GeographicalZone : BaseEntity {
        public BilingualItem Name { get; set; }

        public string ParentsIds { get; set; }
    }

}
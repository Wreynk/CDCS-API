#region

using System.Collections.Generic;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Sector : BaseEntity {
        public BilingualItem Name { get; set; }

        public BilingualItem Description { get; set; }

        public short SortOrder { get; set; }

        // Collections
        public virtual ICollection<SectorCategoriesHierarchy> SectorCategoriesHierarchies { get; set; }
    }

}
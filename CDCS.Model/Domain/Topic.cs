#region

using System.Collections.Generic;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Topic : BaseEntity {
        public BilingualItem Name { get; set; }

        // Collections
        public virtual ICollection<SectorCategoriesHierarchy> Topic1_SectorCategoriesHierarchies { get; set; }
        public virtual ICollection<SectorCategoriesHierarchy> Topic2_SectorCategoriesHierarchies { get; set; }
        public virtual ICollection<SectorCategoriesHierarchy> Topic3_SectorCategoriesHierarchies { get; set; }
        public virtual ICollection<SectorCategoriesHierarchy> Topic4_SectorCategoriesHierarchies { get; set; }
    }

}
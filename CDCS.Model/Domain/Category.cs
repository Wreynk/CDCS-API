#region

using System.Collections.Generic;
using CDCS.Model.Base;
using TLT.BaseModel.Base;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    public class Category : BaseEntity {
        public BilingualItem Name        { get; set; }
        public BilingualItem Description { get; set; }
        public BilingualItem Website     { get; set; }

        public string LinkCategoriesIds { get; set; }

        // Collections
        public virtual ICollection<Keyword_FR> Keywords_FR { get; set; }
        public virtual ICollection<Keyword_NL> Keywords_NL { get; set; }

        public virtual ICollection<SectorCategoriesHierarchy> SectorCategoriesHierarchies { get; set; }
    }

}
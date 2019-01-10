#region

#endregion

#region

using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Model.Domain {

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.

    public class SectorCategoriesHierarchy : BaseEntity {
        public int CategoryId       { get; set; }
        public int SortOrder        { get; set; }
        public int SectorId         { get; set; }
        public int? Topic1Id         { get; set; }
        public int Topic1_SortOrder { get; set; }
        public int? Topic2Id         { get; set; }
        public int Topic2_SortOrder { get; set; }
        public int? Topic3Id         { get; set; }
        public int Topic3_SortOrder { get; set; }
        public int? Topic4Id         { get; set; }
        public int Topic4_SortOrder { get; set; }

        [NotMapped]
        public virtual Category Category { get; set; }

        [NotMapped]
        public virtual Sector   Sector   { get; set; }

        [NotMapped]
        public virtual Topic Topic1 { get; set; }

        [NotMapped]
        public virtual Topic Topic2 { get; set; }

        [NotMapped]
        public virtual Topic Topic3 { get; set; }

        [NotMapped]
        public virtual Topic Topic4 { get; set; }
    }

}
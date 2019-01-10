#region

using System.Collections.Generic;
using CDCS.Model.Domain;

#endregion

namespace CDCS.Model.Base {

    public class CategoriesInput {
        public List<Category>                  Categories                  { get; set; }
        public List<Sector>                    Sectors                     { get; set; }
        public List<SectorCategoriesHierarchy> SectorCategoriesHierarchies { get; set; }
        public List<Topic>                     Topics                      { get; set; }
    }

}
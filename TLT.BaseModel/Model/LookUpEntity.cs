#region

using TLT.BaseModel.Base;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model {

    public abstract class LookUpEntity : BaseEntity, ISortableItem {
        public BilingualItem Name        { get; set; }
        public BilingualItem Description { get; set; }

        public int? SortOrder { get; set; }
    }

}
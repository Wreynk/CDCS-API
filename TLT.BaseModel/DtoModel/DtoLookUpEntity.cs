#region

using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.DtoModel {

    public abstract class DtoLookUpEntity : DtoEntity, ISortableItem {
        public string Name        { get; set; }
        public string Description { get; set; }

        public int? SortOrder { get; set; }
    }

}
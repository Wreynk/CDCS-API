#region

using System.Collections.Generic;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.DtoModel {

    public abstract class DtoHierarchicalEntity<T> : DtoEntity, IHierarchicalItem<T> {
        public string Name { get; set; }

        public int    DepthLevel    { get; set; }
        public bool   HasChildren   { get; set; }
        public string HierarchyName { get; set; }

        public int?           ParentId { get; set; }
        public T              Parent   { get; set; }
        public ICollection<T> Children { get; set; }
    }

}
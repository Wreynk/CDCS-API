#region

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model {

    public abstract class HierarchicalLookUpEntity<T> : LookUpEntity, IHierarchicalItem<T> {
        [NotMapped]
        public bool IsParent => Children.Any();

        public int? ParentId { get; set; }
        public T    Parent   { get; set; }

        public ICollection<T> Children { get; set; }
    }

}
#region

using System.Collections.Generic;

#endregion

namespace TLT.BaseModel.Interfaces {

    public interface IHierarchicalItem<T> {

        int?           ParentId { get; set; }
        T              Parent   { get; set; }
        ICollection<T> Children { get; set; }

    }

}
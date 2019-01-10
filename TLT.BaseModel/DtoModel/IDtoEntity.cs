#region

using System;

#endregion

namespace TLT.BaseModel.DtoModel {}

namespace TLT.BaseModel.DtoModel {

    public interface IDtoEntity {
        int Id { get; set; }
        byte[] RowVersion { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
    }

}
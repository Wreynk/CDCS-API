#region

using System;
using TLT.BaseModel.Helpers;

#endregion

namespace TLT.BaseModel.Interfaces {

    public interface IBaseEntity {

        int Id { get; set; }

        DateTime? CreatedOn  { get; set; }
        string    CreatedBy  { get; set; }
        DateTime? ModifiedOn { get; set; }
        string    ModifiedBy { get; set; }
        DateTime? RemovedOn  { get; set; }

        byte[]      RowVersion  { get; set; }
        // ObjectState ObjectState { get; set; }

    }

}
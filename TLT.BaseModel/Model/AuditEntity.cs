#region

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace TLT.BaseModel.Model {

    public class AuditEntity {
        protected AuditEntity()
        {
            var nowTime = DateTime.Now;
            CreatedOn  = nowTime;
            ModifiedOn = nowTime;
            CreatedBy  = "Admin";
            ModifiedBy = "Admin";
        }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
        public string    CreatedBy  { get; set; }
        public string    ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? RemovedOn { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }

}
using System;
using System.ComponentModel.DataAnnotations;

namespace TLT.BaseModel.DtoModel {

    public abstract class DtoEntity : IDtoEntity {
        public int Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public string    ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }

}
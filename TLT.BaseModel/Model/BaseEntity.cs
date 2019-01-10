#region

using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model
{

    public class BaseEntity : AuditEntity, IBaseEntity
    {
        public int Id { get; set; }
    }

}
#region
using System;
using Microsoft.EntityFrameworkCore;
#endregion


namespace TLT.BaseModel.Helpers {
    public class StateHelper {

        public static EntityState ConvertState(ObjectState state)
        {
            switch (state) {
                case ObjectState.ADDED:
                    return EntityState.Added;
                case ObjectState.MODIFIED:
                    return EntityState.Modified;
                case ObjectState.DELETED:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

        public static ObjectState ConvertState(EntityState state)
        {
            switch (state) {
                case EntityState.Detached:
                    return ObjectState.UNCHANGED;
                case EntityState.Unchanged:
                    return ObjectState.UNCHANGED;
                case EntityState.Added:
                    return ObjectState.ADDED;
                case EntityState.Deleted:
                    return ObjectState.DELETED;
                case EntityState.Modified:
                    return ObjectState.MODIFIED;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state));
            }
        }

    }
}
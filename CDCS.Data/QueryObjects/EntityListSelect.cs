#region

using System;
using System.Collections.Generic;
using System.Linq;
using TLT.BaseModel.Interfaces;

#endregion

namespace CDCS.Data.QueryObjects {

    public static class EntityListSelect {
        public static void Remove<T>(this IEnumerable<T> qry, DateTime removed_on) where T : IBaseEntity
        {
            qry.ToList().ForEach(x => x.RemovedOn = removed_on);
        }

        public static T Find<T>(this IEnumerable<T> qry, int id) where T : IBaseEntity
        {
            return qry.SingleOrDefault(x => x.Id == id);
        }

        public static bool DeleteId<T>(this IList<T> qry, int id) where T : IBaseEntity
        {
            return qry.Remove(qry.Find(id));
        }
    }

}
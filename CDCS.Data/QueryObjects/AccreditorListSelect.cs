#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CDCS.Model;
using CDCS.Model.Domain;
using CDCS.Model.Dtos;
using CDCS.Model.Profiles;
using Microsoft.EntityFrameworkCore;

#endregion

namespace CDCS.Data.QueryObjects
{

    public static class AccreditorListSelect
    {

        public static Accreditor FindByRoleName(this IQueryable<Accreditor> qry, int id)
        {
            return qry.FirstOrDefault(x => x.Id == id);
        }

        public static IQueryable<Accreditor> AllIncluding(params Expression<Func<Accreditor, object>>[] includeProperties)
        {
            using (var context = new CdcsContext())
            {
                IQueryable<Accreditor> qry = context.Accreditors;

                foreach (var includeProperty in includeProperties)
                    qry = qry.Include(includeProperty);
                return qry;
            }
        }

        public static async Task<AccreditorDto> GetAccreditorDtoByIdAsync(this IQueryable<Accreditor> qry, int id)
        {
            // REMOVE
            // var config = new MapperConfiguration(cfg => cfg.AddProfile<CdcsDtoProfiles>());
            // config.AssertConfigurationIsValid();
            // _mapper = config.CreateMapper();
            var accreditor = await qry.ProjectTo<AccreditorDto>().Where(x => x.Id == id).FirstOrDefaultAsync();
            return accreditor;
        }

    }

}
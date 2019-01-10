#region

using CDCS.Data.Repository.Base;
using CDCS.Data.Repository.Interfaces;
using CDCS.Model.Domain;

#endregion

namespace CDCS.Data.Repository {

    public class AccreditorRepository : AppRepository<Accreditor>, IAccreditorRepository {
        public AccreditorRepository(CdcsContext context) : base(context) {}
    }

}
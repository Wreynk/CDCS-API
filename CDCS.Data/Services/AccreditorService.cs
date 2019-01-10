using System.Linq;
using AutoMapper;
using CDCS.Data.Repository.Interfaces;
using CDCS.Data.Services.Base;
using CDCS.Data.Services.Interfaces;
using CDCS.Model.Domain;

namespace CDCS.Data.Services
{

    public class AccreditorService :  IAccreditorService
    {
        private readonly IMapper _mapper;
        private readonly IAccreditorRepository _repo;

        public AccreditorService(IMapper mapper, IAccreditorRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public IQueryable<Accreditor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Accreditor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Accreditor obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Accreditor obj)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }

}
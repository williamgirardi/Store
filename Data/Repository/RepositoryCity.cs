using Data.Context;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Data.Repository
{
    public class RepositoryCity : RepositoryBase<City>, IRepositoryCity
    {
        public RepositoryCity(ContextDb context) : base(context)
        {
        }
    }
}

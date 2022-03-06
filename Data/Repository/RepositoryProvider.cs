using Data.Context;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Data.Repository
{
    public class RepositoryProvider : RepositoryBase<Provider>, IRepositoryProvider
    {
        public RepositoryProvider(ContextDb contex) : base(contex)
        {
        }
    }
}

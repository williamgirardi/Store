using Data.Context;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Data.Repository
{
    public class RepositoryClient : RepositoryBase<Client>, IRepositoryClient
    {
        public RepositoryClient(ContextDb context) : base(context)
        {
        }
    }
}

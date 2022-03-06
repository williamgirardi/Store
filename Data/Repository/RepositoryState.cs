using Data.Context;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Data.Repository
{
    public class RepositoryState : RepositoryBase<State>, IRepositoryState
    {
        public RepositoryState(ContextDb context) : base(context)
        {
        }
    }
}

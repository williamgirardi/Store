using Data.Context;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Entities.Interfaces;

namespace Data.Repository
{
    public class RepositoryEmployee : RepositoryBase<Employee>, IRepositoryEmployee
    {
        public RepositoryEmployee(ContextDb context) : base(context)
        {
        }
    }
}

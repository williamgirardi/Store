using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int Id);
        Task<TEntity> GetById(int Id);
        IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate);
        TEntity Get(Func<TEntity, bool> predicate);
    }
}

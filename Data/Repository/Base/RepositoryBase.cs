using Domain.Entities.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Base
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly Context.ContextDb _context;
        private DbSet<TEntity> _dataset;

        public RepositoryBase(Context.ContextDb context)
        {
            _context = context;
            _dataset = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity == null)
                return entity;

            //TODO - Verificar
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public TEntity Get(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public async Task<TEntity> GetById(int Id)
        {
            var result = await _context.Set<TEntity>().FindAsync(Id);
            return result;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

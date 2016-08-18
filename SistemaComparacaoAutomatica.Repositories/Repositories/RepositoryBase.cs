using SistemaComparacaoAutomatica.Data.Contexts;
using SistemaComparacaoAutomatica.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SistemaComparacaoAutomatica.Repositories.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly SistemaComparacaoContext _DataBase;

        public RepositoryBase(SistemaComparacaoContext DataBase)
        {
            _DataBase = DataBase;   
        }
        

        public void Add(TEntity obj)
        {
            _DataBase.Set<TEntity>().Add(obj);
            _DataBase.SaveChanges();
        }

        
        public IEnumerable<TEntity> GetAll()
        {
            return _DataBase.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _DataBase.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _DataBase.Set<TEntity>().Remove(obj);
            _DataBase.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _DataBase.Entry(obj).State = EntityState.Modified;
            _DataBase.SaveChanges();
        }

        public void Dispose()
        {
            
        }
    }
}

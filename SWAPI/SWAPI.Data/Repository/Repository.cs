using Microsoft.EntityFrameworkCore;
using SWAPI.Domain.Interfaces.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWAPI.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(DbContext Context)
        {
            this.context = Context;
            this.DbSet = Context.Set<TEntity>();
        }

        public void Incluir(TEntity entity)
        {
            DbSet.Add(entity);
            context.SaveChanges();
        }

        public void Alterar(TEntity entity)
        {
            var entry = context.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Excluir(object id)
        {
            TEntity entity = DbSet.Find(id);
            DbSet.Remove(entity);
            context.SaveChanges();
        }

        public TEntity Obter(object id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> Listar()
        {
            return DbSet.ToList();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (context == null) return;
            context.Dispose();
        }
    }
}

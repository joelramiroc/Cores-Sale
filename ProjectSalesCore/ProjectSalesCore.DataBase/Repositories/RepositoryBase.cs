// <copyright file="RepositoryBase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;
    using CSales.Database.Contexts;

    public abstract class RepositoryBase
        <TEntity, TContext> : IRepository<TEntity>
          where TEntity : class
          where TContext : DbContext
    {
        public RepositoryBase(TContext context)
        {
            this.Context = context;
        }

        public virtual TContext Context { get; protected set; }

        public abstract IQueryable<TEntity> All();

        public virtual TEntity Create()
        {
            IDbSet<TEntity> set = this.Context.Set<TEntity>();
            var entity = set.Create();
            this.Context.Entry(entity).State = EntityState.Added;
            return entity;
        }

        public virtual TEntity Create(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Added;
            return entity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Deleted;
            return entity;
        }

        public virtual TEntity Find(int id)
        {
            return ((DbSet<TEntity>)this.All()).Find(id);
        }

        public virtual Task<TEntity> FindAsync(int id)
        {
            return ((DbSet<TEntity>)this.All()).FindAsync(id);
        }

        private TEntity First()
        {
            return this.Context.Set<TEntity>().First();
        }

        public virtual Task<TEntity> FirstAsync()
        {
            return this.Context.Set<TEntity>().FirstAsync();
        }

        public virtual TEntity FirstOrDefault()
        {
            return this.Context.Set<TEntity>().FirstOrDefault();
        }

        public virtual Task<TEntity> FirstOrDefaultAsync()
        {
            return this.Context.Set<TEntity>().FirstOrDefaultAsync();
        }

        public virtual int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        public virtual Task<int> SaveChangesAsync()
        {
            try
            {
                return this.Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // throw new DataConcurrencyException(ex.Message, ex);
                return null;
            }
        }

        public virtual TEntity Update(TEntity entity)
        {
            var entry = this.Context.Entry(entity);
            entry.State = EntityState.Modified;
            return entity;
        }

        public virtual TEntity Update(TEntity oldEntity, TEntity newEntity)
        {
            var newEntry = this.Context.Entry(newEntity);
            newEntry.State = EntityState.Detached;

            var oldEntry = this.Context.Entry(oldEntity);
            oldEntry.State = EntityState.Modified;

            return this.MapNewValuesToOld(oldEntity, newEntity);
        }

        protected abstract TEntity MapNewValuesToOld(TEntity oldEntity, TEntity newEntity);

        TEntity IRepository<TEntity>.First()
        {
            return this.First();
        }
    }
}

// <copyright file="IRepository.cs" company="Leitz Group">
// Copyright (c) Leitz Group. All rights reserved.
// </copyright>

namespace Database.Repository
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IRepository<TEntity>
        where TEntity : class
    {
        IQueryable<TEntity> All();

        TEntity Create();

        TEntity Create(TEntity entity);

        TEntity Delete(TEntity entity);

        // IQueryable<TEntity> Filter(IEnumerable<PropertyFilter> filters);
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

        TEntity Find(params object[] keys);

        Task<TEntity> FindAsync(params object[] keys);

        Task<TEntity> FindAsync(CancellationToken token, params object[] keys);

        // TEntity First(IEnumerable<PropertyFilter> filters);
        TEntity First(Expression<Func<TEntity, bool>> predicate);

        // Task<TEntity> FirstAsync(IEnumerable<PropertyFilter> filters);
        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate);

        // TEntity FirstOrDefault(IEnumerable<PropertyFilter> filters);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        // Task<TEntity> FirstOrDefaultAsync(IEnumerable<PropertyFilter> filters);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        int SaveChanges();

        Task<int> SaveChangesAsync();

        IQueryable<TResult> Transform<TResult>(Expression<Func<TEntity, TResult>> predicate);

        TEntity Update(TEntity entity);

        TEntity Update(TEntity oldEntity, TEntity newEntity);

        void SetOriginalValue<TValue>(TEntity entity, string propertyName, TValue value);
    }
}
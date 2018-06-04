// <copyright file="IRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Repositories
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


        TEntity Find(int id);

        Task<TEntity> FindAsync(int id);

        TEntity First();

        TEntity FirstOrDefault();

        Task<TEntity> FirstOrDefaultAsync();

        int SaveChanges();

        Task<int> SaveChangesAsync();

        TEntity Update(TEntity entity);

        TEntity Update(TEntity oldEntity, TEntity newEntity);
    }
}
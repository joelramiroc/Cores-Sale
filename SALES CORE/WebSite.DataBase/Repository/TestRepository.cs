// <copyright file="JobRepository.cs" company="Leitz Group">
// Copyright (c) Leitz Group. All rights reserved.
// </copyright>

namespace WebSite.DataBase.Repository
{
    using System.Linq;
    using WebSite.DataBase.Context;
    using WebSite.DataBase.Model;

    public class TestRepository : BaseRepository<Tests>
    {
        public TestRepository(TestsContext agentDbContext)
            : base(agentDbContext)
        {
        }

        public override IQueryable<Tests> All()
        {
            return this.Context.Tests;
        }

        protected override Tests MapNewValuesToOld(Tests oldEntity, Tests newEntity)
        {
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            return oldEntity;
        }
    }
}

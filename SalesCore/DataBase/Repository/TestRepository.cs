// <copyright file="JobRepository.cs" company="Leitz Group">
// Copyright (c) Leitz Group. All rights reserved.
// </copyright>

namespace Database.Repository
{
    using DataBase.Context;
    using DataBase.Model;
    using System.Linq;

    public class TestRepository : BaseRepository<Test>
    {
        public TestRepository(TestContext agentDbContext)
            : base(agentDbContext)
        {
        }

        public override IQueryable<Test> All()
        {
            return this.Context.Tests;
        }

        protected override Test MapNewValuesToOld(Test oldEntity, Test newEntity)
        {
            oldEntity.Id = newEntity.Id;
            oldEntity.Name = newEntity.Name;
            return oldEntity;
        }
    }
}

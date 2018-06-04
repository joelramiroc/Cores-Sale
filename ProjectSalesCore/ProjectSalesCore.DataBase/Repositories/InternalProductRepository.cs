// <copyright file="InternalProductRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSales.Database.Contexts;
    using CSales.Database.Models;

    public class InternalProductRepository : CSalesRepositoryBase<InternalProduct>
    {
        public InternalProductRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<InternalProduct> All()
        {
            return this.Context.InternalProduct;
        }

        protected override InternalProduct MapNewValuesToOld(InternalProduct oldEntity, InternalProduct newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

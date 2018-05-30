// <copyright file="SalesByDispatchRepository.cs" company="PlaceholderCompany">
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

    public class SalesByDispatchRepository : CSalesRepositoryBase<SalesByDispatch>
    {
        public SalesByDispatchRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<SalesByDispatch> All()
        {
            return this.Context.SalesByDispatch;
        }

        protected override SalesByDispatch MapNewValuesToOld(SalesByDispatch oldEntity, SalesByDispatch newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

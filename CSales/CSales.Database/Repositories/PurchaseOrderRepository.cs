// <copyright file="PurchaseOrderRepository.cs" company="PlaceholderCompany">
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

    public class PurchaseOrderRepository : CSalesRepositoryBase<PurchaseOrder>
    {
        public PurchaseOrderRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<PurchaseOrder> All()
        {
            return this.Context.PurchaseOrder;
        }

        protected override PurchaseOrder MapNewValuesToOld(PurchaseOrder oldEntity, PurchaseOrder newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

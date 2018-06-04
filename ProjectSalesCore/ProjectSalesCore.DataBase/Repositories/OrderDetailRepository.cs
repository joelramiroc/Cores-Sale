// <copyright file="OrderDetailRepository.cs" company="PlaceholderCompany">
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

    public class OrderDetailRepository : CSalesRepositoryBase<OrderDetail>
    {
        public OrderDetailRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<OrderDetail> All()
        {
            return this.Context.OrderDetail;
        }

        protected override OrderDetail MapNewValuesToOld(OrderDetail oldEntity, OrderDetail newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

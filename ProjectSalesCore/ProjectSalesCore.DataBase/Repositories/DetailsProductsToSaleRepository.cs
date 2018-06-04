// <copyright file="DetailsProductsToSaleRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Repositories
{
    using System;
    using System.Linq;
    using Contexts;
    using Models;

    public class DetailsProductsToSaleRepository : CSalesRepositoryBase<DetailsProductsToSale>
    {
        public DetailsProductsToSaleRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<DetailsProductsToSale> All()
        {
            return this.Context.DetailsProductsToSale;
        }

        protected override DetailsProductsToSale MapNewValuesToOld(DetailsProductsToSale oldEntity, DetailsProductsToSale newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

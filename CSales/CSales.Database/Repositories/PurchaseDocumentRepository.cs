// <copyright file="PurchaseDocumentRepository.cs" company="PlaceholderCompany">
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

    public class PurchaseDocumentRepository : CSalesRepositoryBase<PurchaseDocument>
    {
        public PurchaseDocumentRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<PurchaseDocument> All()
        {
            return this.Context.PurchaseDocument;
        }

        protected override PurchaseDocument MapNewValuesToOld(PurchaseDocument oldEntity, PurchaseDocument newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

// <copyright file="TypeOfPuchaseDocumentRepository.cs" company="PlaceholderCompany">
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

    public class TypeOfPuchaseDocumentRepository : CSalesRepositoryBase<TypeOfPurchaseDocument>
    {
        public TypeOfPuchaseDocumentRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<TypeOfPurchaseDocument> All()
        {
            return this.Context.TypeOfPurchaseDocument;
        }

        protected override TypeOfPurchaseDocument MapNewValuesToOld(TypeOfPurchaseDocument oldEntity, TypeOfPurchaseDocument newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

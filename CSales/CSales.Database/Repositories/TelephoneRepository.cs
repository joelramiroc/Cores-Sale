// <copyright file="TelephoneRepository.cs" company="PlaceholderCompany">
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

    public class TelephoneRepository : CSalesRepositoryBase<Telephone>
    {
        public TelephoneRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<Telephone> All()
        {
            return this.Context.Telephone;
        }

        protected override Telephone MapNewValuesToOld(Telephone oldEntity, Telephone newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

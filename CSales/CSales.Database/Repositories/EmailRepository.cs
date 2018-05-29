// <copyright file="EmailRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contexts;
    using Models;

    public class EmailRepository : CSalesRepositoryBase<Email>
    {
        public EmailRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<Email> All()
        {
            return this.Context.Email;
        }

        protected override Email MapNewValuesToOld(Email oldEntity, Email newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

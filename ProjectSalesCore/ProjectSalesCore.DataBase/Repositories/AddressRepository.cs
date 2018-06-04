// <copyright file="AddressRepository.cs" company="PlaceholderCompany">
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

    public class AddressRepository : CSalesRepositoryBase<Address>
    {
        public AddressRepository(MyContext context)
            : base(context)
        {
        }

        public override IQueryable<Address> All()
        {
            return this.Context.Address;
        }

        protected override Address MapNewValuesToOld(Address oldEntity, Address newEntity)
        {
            throw new NotImplementedException();
        }
    }
}

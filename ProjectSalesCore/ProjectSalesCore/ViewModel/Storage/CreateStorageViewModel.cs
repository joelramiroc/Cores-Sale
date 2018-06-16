﻿namespace ProjectSalesCore.ViewModel.Storage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using CSales.Models;

    public class CreateStorageViewModel
    {
        public string StorageName { get; set; }

        public Address Address { get; set; }

        public IEnumerable<Telephone> Telephones { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
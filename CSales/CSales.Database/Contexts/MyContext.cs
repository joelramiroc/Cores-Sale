// <copyright file="MyContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;
    using FirebirdSql.Data.FirebirdClient;

    public class MyContext : DbContext
    {
        public MyContext()
            : base(new FbConnection(@"database=localhost:C:\BASE\TEST.FDB;user=SYSDBA;password=masterkey"), true)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Provider> Provider { get; set; }
    }
}
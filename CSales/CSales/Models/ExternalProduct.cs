// <copyright file="ExternalProduct.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExternalProduct
    {
        [Key]
        public long IdExternalProduct { get; set; }

        [ForeignKey(nameof(Product))]
        public long IdProduct { get; set; }

        public virtual Product Product { get; set; }

        [ForeignKey(nameof(UnitOfMeasurement))]
        public long IdUnitOfMeasurement { get; set; }

        public virtual UnitOfMeasurement UnitOfMeasurement { get; set; }

        [ForeignKey(nameof(ProductType))]
        public long IdProductType { get; set; }

        public virtual ProductType ProductType { get; set; }

        [ForeignKey(nameof(ProductLine))]
        public long IdProductLine { get; set; }

        public virtual ProductLine ProductLine { get; set; }

        public string ProductDescription { get; set; }

        public int Quantity { get; set; }

        public bool Active { get; set; }
    }
}

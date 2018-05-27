// <copyright file="ExternalInventory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ExternalInventory
    {
        [Key]
        public long IdExternalInventory { get; set; }

        [ForeignKey(nameof(ExternalProduct))]
        public long IdExternalProduct { get; set; }

        public virtual ExternalProduct ExternalProduct { get; set; }

        [ForeignKey(nameof(Storage))]
        public long IdStorage { get; set; }

        public virtual Storage Storage { get; set; }

        public string ProductDescription { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int DiscountRate { get; set; }

        public int MinimumStock { get; set; }

        public int MaximumStock { get; set; }
    }
}

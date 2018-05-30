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

    [Table("EXTERNALINVENTORY")]

    public class ExternalInventory
    {
        [Key]
        [Column("IDEXTERNALINVENTORY")]
        public long IdExternalInventory { get; set; }

        [ForeignKey(nameof(ExternalProduct))]
        [Column("IDEXTERNALPRODUCT")]
        public long IdExternalProduct { get; set; }

        [Column("EXTERNALPRODUCT")]
        public virtual ExternalProduct ExternalProduct { get; set; }

        [ForeignKey(nameof(Storage))]
        [Column("IDSTORAGE")]
        public long IdStorage { get; set; }

        [Column("STORAGE")]
        public virtual Storage Storage { get; set; }

        [Column("PRODUCTDESCRIPTION")]
        public string ProductDescription { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("UNITPRICE")]
        public decimal UnitPrice { get; set; }

        [Column("DISCOUNTRATE")]
        public int DiscountRate { get; set; }

        [Column("MINIMUMSTOCK")]
        public int MinimumStock { get; set; }

        [Column("MAXIMUMSTOCK")]
        public int MaximumStock { get; set; }
    }
}

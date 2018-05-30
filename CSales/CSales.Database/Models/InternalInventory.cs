// <copyright file="InternalInventory.cs" company="PlaceholderCompany">
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

    [Table("INTERNALINVENTORY")]

    public class InternalInventory
    {
        [Key]
        [Column("IDINTERNALINVENTORY")]
        public long IdInternalInventory { get; set; }

        [ForeignKey(nameof(Storage))]
        [Column("IDSTORAGE")]
        public long IdStorage { get; set; }

        [Column("SOTRAGE")]
        public virtual Storage Storage { get; set; }

        [ForeignKey(nameof(InternalProduct))]
        [Column("IDINTERNALPRODUCT")]
        public long IdInternalProduct { get; set; }

        [Column("INTERNALPRODUCT")]
        public virtual InternalProduct InternalProduct { get; set; }

        [Column("PRODUCTDESCRIPTION")]
        public string ProductDescription { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }
    }
}

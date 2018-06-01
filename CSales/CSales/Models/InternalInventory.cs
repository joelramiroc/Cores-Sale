// <copyright file="InternalInventory.cs" company="PlaceholderCompany">
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

    public class InternalInventory
    {
        [Key]
        public long IdInternalInventory { get; set; }

        [ForeignKey(nameof(Storage))]
        public long IdStorage { get; set; }

        public virtual Storage Storage { get; set; }

        [ForeignKey(nameof(InternalProduct))]
        public long IdInternalProduct { get; set; }

        public virtual InternalProduct InternalProduct { get; set; }

        public string ProductDescription { get; set; }

        public int Quantity { get; set; }
    }
}

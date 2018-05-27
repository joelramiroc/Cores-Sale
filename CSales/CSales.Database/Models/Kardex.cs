// <copyright file="Kardex.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Kardex
    {
        [ForeignKey(nameof(MovementType))]
        public long IdMovementType { get; set; }

        public virtual MovementType MovementType { get; set; }

        [ForeignKey(nameof(Product))]
        public long IdProduct { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int DiscountRate { get; set; }

        public decimal Total { get; set; }

        [ForeignKey(nameof(Storage))]
        public long IdStorage { get; set; }

        public virtual Storage Storage { get; set; }

        public DateTime MovementDate { get; set; }

        public decimal PreviousBalance { get; set; }

        public decimal NewBalance { get; set; }

        public int PreviousStock { get; set; }

        public int NewStock { get; set; }
    }
}

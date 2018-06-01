// <copyright file="CounterSale.cs" company="PlaceholderCompany">
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

    public class CounterSale
    {
        [Key]
        public long IdCounterSale { get; set; }

        [ForeignKey(nameof(Bill))]
        public long IdBill { get; set; }

        public virtual Bill Bill { get; set; }
    }
}

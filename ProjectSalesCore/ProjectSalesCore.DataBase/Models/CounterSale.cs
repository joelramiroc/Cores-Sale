﻿// <copyright file="CounterSale.cs" company="PlaceholderCompany">
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

    [Table("CSALE")]

    public class CounterSale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [ForeignKey(nameof(Bill))]
        [Column("IDBILL")]
        public int IdBill { get; set; }

        [Column("BILL")]
        public virtual Bill Bill { get; set; }
    }
}

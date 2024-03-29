﻿// <copyright file="SalesByDispatch.cs" company="PlaceholderCompany">
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

    [Table("SALESBYDISPATCH")]

    public class SalesByDispatch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSALESDISPATCH")]
        public long IdSalesByDispatch { get; set; }

        [Column("BILLS")]
        public ICollection<Bill> Bills { get; set; }
    }
}

// <copyright file="SalesByDispatch.cs" company="PlaceholderCompany">
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

    public class SalesByDispatch
    {
        [Key]
        public long IdSalesByDispatch { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}

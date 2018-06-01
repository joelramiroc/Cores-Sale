// <copyright file="OrderDetail.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderDetail
    {
        [ForeignKey(nameof(ExternalProduct))]
        public long IdExternalProduct { get; set; }

        public ExternalProduct ExternalProduct { get; set; }

        [ForeignKey(nameof(ExternalProduct))]
        public long IdSaleOrder { get; set; }

        public SaleOrder SaleOrder { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int DiscountRate { get; set; }

        public decimal Total { get; set; }
    }
}

// <copyright file="OrderDetail.cs" company="PlaceholderCompany">
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

    [Table("ORDERDETAIL")]

    public class OrderDetail
    {
        [ForeignKey(nameof(ExternalProduct))]
        [Column("IDEXTERNALPRODUCT")]
        public long IdExternalProduct { get; set; }

        [Column("EXTERNALPRODUCT")]
        public ExternalProduct ExternalProduct { get; set; }

        [ForeignKey(nameof(ExternalProduct))]
        [Column("IDSALEORDER")]
        public long IdSaleOrder { get; set; }

        [Column("SALEORDER")]
        public SaleOrder SaleOrder { get; set; }

        [Column("QUANTITY")]
        public int Quantity { get; set; }

        [Column("UNITPRICE")]
        public decimal UnitPrice { get; set; }

        [Column("DISCOUNTRATE")]
        public int DiscountRate { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }
    }
}

// <copyright file="OrderDetailsVentas.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.DataBase.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CSales.Database.Models;

    [Table("ODVNTS")]

    public class OrderDetailsVentas
    {
        [Key]
        [ForeignKey(nameof(EProdct))]
        [Column("IDXP", Order = 0)]
        public int IdExternalProduct { get; set; }

        [Column("EPRDCT")]
        public EProduct EProdct { get; set; }

        [Key]
        [ForeignKey(nameof(SaleOrder))]
        [Column("IDSORDER", Order = 1)]
        public int IdSaleOrder { get; set; }

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

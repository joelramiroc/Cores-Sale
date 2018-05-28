// <copyright file="DetailsPurchaseOrder.cs" company="PlaceholderCompany">
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

    public class DetailsProductsToSale
    {
        [Key]
        public long IdDetailsProductsToSale { get; set; }

        [ForeignKey(nameof(Product))]
        public long IdProduct { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal TotalAmount { get; set; }

        [ForeignKey(nameof(PaymentCondition))]
        public long IdPaymentCondition { get; set; }

        public virtual PaymentCondition PaymentCondition { get; set; }

        [ForeignKey(nameof(PurchaseOrder))]
        public long IdPurchaseOrder { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}

// <copyright file="SaleOrder.cs" company="PlaceholderCompany">
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

    public class SaleOrder
    {
        public long IdSaleOrder { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(Client))]
        public long IdClient { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        public long IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(PaymentCondition))]
        public long IdPaymentCondition { get; set; }

        public virtual PaymentCondition PaymentCondition { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

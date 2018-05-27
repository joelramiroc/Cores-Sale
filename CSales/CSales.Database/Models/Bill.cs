// <copyright file="Bill.cs" company="PlaceholderCompany">
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

    public class Bill
    {
        [Key]
        public long IdBill { get; set; }

        [ForeignKey(nameof(Client))]
        public long IdClient { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        public long IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }

        public DateTime CreatedDate { get; set; }

        public ICollection<OrderDetail> OrdersDetail { get; set; }

        public decimal Total { get; set; }
    }
}

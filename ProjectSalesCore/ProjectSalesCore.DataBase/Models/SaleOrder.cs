// <copyright file="SaleOrder.cs" company="PlaceholderCompany">
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

    [Table("SOR")]

    public class SaleOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public long IdSaleOrder { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT")]
        public long IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [ForeignKey(nameof(Employee))]
        [Column("IDEMPLOYEE")]
        public long IdEmployee { get; set; }

        [Column("EMPLOYEE")]
        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(PaymentCondition))]
        [Column("IDPCONDITION")]
        public long IdPaymentCondition { get; set; }

        [Column("PAYMENTCONDITION")]
        public virtual PaymentCondition PaymentCondition { get; set; }

        [Column("ODETAILS")]
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

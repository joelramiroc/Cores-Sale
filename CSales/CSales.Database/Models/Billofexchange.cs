// <copyright file="Billofexchange.cs" company="PlaceholderCompany">
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

    [Table("BILLOFEXCHANGE")]

    public class BillOfExchange
    {
        [Key]
        [Column("IDBILLOFEXCHANGE")]
        public long IdBillOfExchange { get; set; }

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

        [Column("PAYMENTDATE")]
        public DateTime PaymentDate { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }

    }
}

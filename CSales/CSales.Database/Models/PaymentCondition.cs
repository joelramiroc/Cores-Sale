// <copyright file="PaymentCondition.cs" company="PlaceholderCompany">
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

    [Table("PAYMENTCONDITION")]

    public class PaymentCondition
    {
        [Key]
        [Column("IDPAYMENTCONDITION")]
        public long IdPaymentCondition { get; set; }

        [Column("CONDITIONNAME")]
        public string ConditionName { get; set; }
    }
}

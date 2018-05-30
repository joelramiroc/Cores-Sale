// <copyright file="PaymentMethod.cs" company="PlaceholderCompany">
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

    [Table("PAYMENTMETHOD")]

    public class PaymentMethod
    {
        [Key]
        [Column("IDPAYMENTMETHOD")]
        public long IdPaymentMethod { get; set; }

        [Column("METHODNAME")]
        public string MethodName { get; set; }
    }
}

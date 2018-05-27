﻿// <copyright file="PaymentCondition.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PaymentCondition
    {
        [Key]
        public long IdPaymentCondition { get; set; }

        public string ConditionName { get; set; }
    }
}

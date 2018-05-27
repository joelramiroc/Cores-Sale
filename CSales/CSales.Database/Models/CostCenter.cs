// <copyright file="CostCenter.cs" company="PlaceholderCompany">
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

    public class CostCenter
    {
        [Key]
        public long IdCostCenter { get; set; }

        public string CostName { get; set; }
    }
}

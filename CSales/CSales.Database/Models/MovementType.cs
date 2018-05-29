// <copyright file="MovimentType.cs" company="PlaceholderCompany">
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

    public class MovementType
    {
        [Key]
        public long IdMovimentType { get; set; }

        public string MovimentName { get; set; }
    }
}

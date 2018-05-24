// <copyright file="CurrentAccountProvider.cs" company="PlaceholderCompany">
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

    public class CurrentAccountProvider
    {
        [Key]
        public long IdCurrentAccountProvider { get; set; }

        [ForeignKey(nameof(Provider))]
        public long IdProvider { get; set; }

        public virtual Provider Provider { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

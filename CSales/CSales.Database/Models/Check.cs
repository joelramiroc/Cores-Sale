﻿// <copyright file="Check.cs" company="PlaceholderCompany">
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

    [Table("CHECK")]

    public class Check
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCHECK")]
        public long IdCheck { get; set; }

        [Column("CHECKNUMBER")]
        public int ChekNumber { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT")]
        public long IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [Column("PAYMENTDATE")]
        public DateTime PaymentDate { get; set; }
    }
}

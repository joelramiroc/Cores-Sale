// <copyright file="CustomerCheckingAccount.cs" company="PlaceholderCompany">
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

    [Table("CUSTOMERCHECKINGACCOUNT")]

    public class CustomerCheckingAccount
    {
        [Key]
        [Column("IDCUSTOMERCHECKINGACCOUNT")]
        public long IdCustomerCheckingAccount { get; set; }

        [ForeignKey(nameof(Client))]
        [Column("IDCLIENT")]
        public long IdClient { get; set; }

        [Column("CLIENT")]
        public virtual Client Client { get; set; }

        [Column("TOTALDEBT")]
        public decimal TotalDebt { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}

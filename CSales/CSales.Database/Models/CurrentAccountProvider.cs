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

    [Table("CURRENTACCOUNTPROVIDER")]

    public class CurrentAccountProvider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCURRENTACCOUNTPROVIDER")]
        public long IdCurrentAccountProvider { get; set; }

        [ForeignKey(nameof(Provider))]
        [Column("IDPROVIDER")]
        public long IdProvider { get; set; }

        [Column("PROVIDER")]
        public virtual Provider Provider { get; set; }

        [Column("TOTALDEBT")]
        public decimal TotalDebt { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}

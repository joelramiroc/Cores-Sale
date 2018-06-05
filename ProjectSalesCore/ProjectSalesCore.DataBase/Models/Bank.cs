// <copyright file="Bank.cs" company="PlaceholderCompany">
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

    [Table("BANK")]

    public class Bank
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IDBANK")]
        public long IdBank { get; set; }

        [Column("BANKNAME")]
        public string BankName { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("TELEPHONES")]
        public ICollection<Telephone> Telephones { get; set; }

        [Column("ADDRESSES")]
        public ICollection<Address> Addresses { get; set; }
    }
}

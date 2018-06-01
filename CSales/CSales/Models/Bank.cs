// <copyright file="Bank.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank
    {
        [Key]
        public long IdBank { get; set; }

        public string BankName { get; set; }

        public string Description { get; set; }

        public ICollection<Telephone> Telephones { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}

// <copyright file="Providers.cs" company="PlaceholderCompany">
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

    public class Provider
    {
        [Key]
        public long IdProvider { get; set; }

        public ICollection<Address> Address { get; set; }

        [Required]
        public ICollection<Telephone> Telephones { get; set; }

        [Required]
        public bool Active { get; set; }

        public string City { get; set; }

        public string Contact { get; set; }

        [Required]
        public bool IsForeingProvider { get; set; }

        [ForeignKey(nameof(BusinessName))]
        public long IdBusinessName { get; set; }

        public virtual BusinessName BusinessName { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

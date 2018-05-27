// <copyright file="Storage.cs" company="PlaceholderCompany">
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

    public class Storage
    {
        [Key]
        public long IdStorage { get; set; }

        public string StorageName { get; set; }

        [ForeignKey(nameof(Address))]
        public long IdAddress { get; set; }

        public virtual Address Address { get; set; }

        public ICollection<Telephone> Telephones { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}

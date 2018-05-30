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

    [Table("STORAGE")]

    public class Storage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDSTORAGE")]
        public long IdStorage { get; set; }

        [Column("STORAGENAME")]
        public string StorageName { get; set; }

        [ForeignKey(nameof(Address))]
        [Column("IDADDRESS")]
        public long IdAddress { get; set; }

        [Column("ADDRESSS")]
        public virtual Address Address { get; set; }

        [Column("TELEPHONES")]
        public ICollection<Telephone> Telephones { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }

    }
}

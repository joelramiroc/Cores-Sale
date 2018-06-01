// <copyright file="Providers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("PROVIDER")]

    public class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDPROVIDER")]
        public long IdProvider { get; set; }

        [Column("ADDRESSES")]
        public ICollection<Address> Addresses { get; set; }

        [Required]
        [Column("TELEPHONES")]
        public ICollection<Telephone> Telephones { get; set; }

        [Required]
        [Column("ACTIVE")]
        public bool Active { get; set; }

        [Column("CITIESDISTRICTS")]
        public ICollection<CityDistrict> CitiesDistricts { get; set; }

        [Column("CONTACT")]
        public string Contact { get; set; }

        [Required]
        [Column("ISFOREIGNPROVIDER")]
        public bool IsForeignProvider { get; set; }

        [ForeignKey(nameof(BusinessName))]
        [Column("IDBUSINESSNAME")]
        public long IdBusinessName { get; set; }

        [Column("BUSINESSNAME")]
        public virtual BusinessName BusinessName { get; set; }

        [Column("CREATEDBY")]
        public virtual ApplicationUser CreatedBy { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}

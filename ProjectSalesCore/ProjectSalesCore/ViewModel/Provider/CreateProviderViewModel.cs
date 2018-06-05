// <copyright file="CreateProviderViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.ViewModel.Provider
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using CSales.Database.Models;

    public class CreateProviderViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("ID")]
        public long Id { get; set; }

        [Column("ADDRESSES")]
        public IEnumerable<Address> Addresses { get; set; }

        [Required]
        [Column("TELEP")]
        public IEnumerable<Telephone> Telephones { get; set; }

        [Required]
        [Column("ISACTIVE")]
        public bool IsActive { get; set; }

        [Column("CITIESDISTRICTS")]
        public ICollection<CityDistrict> CitiesDistricts { get; set; }

        [Column("CONTACT")]
        public string Contact { get; set; }

        [Required]
        [Column("ISFOREIGNPROVIDER")]
        public bool IsForeignProvider { get; set; }

        [ForeignKey(nameof(BusinessName))]
        [Column("BUSINESSNAME")]
        public long IdBusinessName { get; set; }

        [Column("BUSINESSNAME")]
        public virtual BusinessName BusinessName { get; set; }

        [Column("CREATEDDATE")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
    }
}
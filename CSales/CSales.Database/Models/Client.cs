// <copyright file="Client.cs" company="PlaceholderCompany">
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

    public class Client
    {
        [Key]
        public long IdClient { get; set; }

        public string Name { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public ICollection<CityDistrict> CitiesDistricts { get; set; }

        public ICollection<Telephone> Telephones { get; set; }

        public ICollection<Fax> Faxs { get; set; }

        public ICollection<Email> Emails { get; set; }

        [ForeignKey(nameof(RUC))]
        public long IdRUC { get; set; }

        public virtual RUC RUC { get; set; }

        [ForeignKey(nameof(Employee))]
        public long IdEmployee { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

// <copyright file="CityDistrict.cs" company="PlaceholderCompany">
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

    [Table("CITYDISCTRICT")]

    public class CityDistrict
    {
        [Key]
        [Column("IDCITYDISCTRICT")]
        public long IdCityDistrict { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }
    }
}

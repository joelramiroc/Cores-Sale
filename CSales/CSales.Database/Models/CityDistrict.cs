// <copyright file="CityDistrict.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CityDistrict
    {
        [Key]
        public long IdCityDistrict { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

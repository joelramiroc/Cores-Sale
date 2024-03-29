﻿// <copyright file="UnitOfMeasurement.cs" company="PlaceholderCompany">
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

    [Table("UNITOFMEASUREMENT")]

    public class UnitOfMeasurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDUNITOFMEASUREMENT")]
        public long IdUnitOfMeasurement { get; set; }

        [Column("UNITNAME")]
        public string UnitName { get; set; }
    }
}

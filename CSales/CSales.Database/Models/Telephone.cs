// <copyright file="Telephone.cs" company="PlaceholderCompany">
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

    [Table("TELEPHONE")]

    public class Telephone
    {
        [Key]
        [Column("IDTELEPHONE")]
        public long IdTelephone { get; set; }

        [Column("NUMBER")]
        public string Number { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }
    }
}

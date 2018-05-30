﻿// <copyright file="MovimentType.cs" company="PlaceholderCompany">
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

    [Table("MOVEMENTTYPE")]

    public class MovementType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDMOVIMENTTYPE")]
        public long IdMovimentType { get; set; }

        [Column("MOVIMENTNAME")]
        public string MovimentName { get; set; }
    }
}
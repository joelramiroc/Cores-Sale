﻿// <copyright file="Telephone.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Telephone
    {
        [Key]
        public long IdTelephone { get; set; }

        public string Number { get; set; }

        public string Description { get; set; }
    }
}

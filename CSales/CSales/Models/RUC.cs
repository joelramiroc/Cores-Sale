﻿// <copyright file="RUC.cs" company="PlaceholderCompany">
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

    public class RUC
    {
        [Key]
        public long IdRUC { get; set; }

        public string RUCName { get; set; }
    }
}

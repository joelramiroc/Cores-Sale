// <copyright file="ProductLine.cs" company="PlaceholderCompany">
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

    [Table("PRODUCTLINE")]

    public class ProductLine
    {
        [Key]
        [Column("IDPRODUCTLINE")]
        public long IdProductLine { get; set; }

        [Column("LINENAME")]
        public string LineName { get; set; }
    }
}

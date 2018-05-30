// <copyright file="CostCenter.cs" company="PlaceholderCompany">
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

    [Table("COSTCENTER")]

    public class CostCenter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCOSTCENTER")]
        public long IdCostCenter { get; set; }

        [Column("COSTNAME")]
        public string CostName { get; set; }
    }
}

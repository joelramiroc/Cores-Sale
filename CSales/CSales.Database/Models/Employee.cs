// <copyright file="Employee.cs" company="PlaceholderCompany">
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

    [Table("EMPLOYEE")]

    public class Employee
    {
        [Key]
        [Column("IDEMPLOYEE")]
        public long IdEmployee { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("TELEPHONES")]
        public ICollection<Telephone> Telephones { get; set; }

        [Column("ADDRESSES")]
        public ICollection<Address> Addresses { get; set; }

        [Column("HIREDATE")]
        public DateTime HireDate { get; set; }

        [Column("SALARY")]
        public decimal Salary { get; set; }
    }
}

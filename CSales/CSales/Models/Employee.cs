// <copyright file="Employee.cs" company="PlaceholderCompany">
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

    public class Employee
    {
        [Key]
        public long IdEmployee { get; set; }

        public string Name { get; set; }

        public ICollection<Telephone> Telephones { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }
    }
}

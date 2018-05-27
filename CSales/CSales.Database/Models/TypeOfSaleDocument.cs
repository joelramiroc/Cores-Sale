// <copyright file="DocumentTypeProvider.cs" company="PlaceholderCompany">
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

    public class TypeOfSaleDocument
    {
        [Key]
        public long IdDocumentTypeProvider { get; set; }

        public string NameDocument { get; set; }
    }
}

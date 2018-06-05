﻿// <copyright file="DocumentTypeProvider.cs" company="PlaceholderCompany">
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

    [Table("TOPDOC")]

    public class TypeOfPurchaseDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long IdDocumentTypeProvider { get; set; }

        [Column("NAMEDOCUMENT")]
        public string NameDocument { get; set; }
    }
}

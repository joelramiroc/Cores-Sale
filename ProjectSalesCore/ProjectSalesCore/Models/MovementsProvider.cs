﻿// <copyright file="MovimentsProvider.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Table("MPROVIDER")]

    public class MovementsProvider
    {
        [Key]
        public long IdMovementsProvider { get; set; }

        [ForeignKey(nameof(DocumentTypeProvider))]
        [Column("IDDTPE")]
        public long IdDocumentType { get; set; }

        [Column("DOCUMENTTYPEPROVIDER")]
        public virtual TypeOfPurchaseDocument DocumentTypeProvider { get; set; }

        [Column("DOCUMENTID")]
        public long DocumentId { get; set; }

        [Column("INGRESOS")]
        public decimal Ingresos { get; set; }

        [Column("EGRESOS")]
        public decimal Egresos { get; set; }

        [Column("CREATEDDATE")]
        public DateTime CreatedDate { get; set; }
    }
}
// <copyright file="MovimentsProvider.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MovementsProvider
    {
        [ForeignKey(nameof(DocumentTypeProvider))]
        public long IdDocumentType { get; set; }

        public virtual TypeOfPurchaseDocument DocumentTypeProvider { get; set; }

        public long DocumentId { get; set; }

        public decimal Ingresos { get; set; }

        public decimal Egresos { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}

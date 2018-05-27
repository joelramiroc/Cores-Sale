// <copyright file="CreditNoteType.cs" company="PlaceholderCompany">
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

    public class CreditNoteType
    {
        [Key]
        public long IdCreditNoteType { get; set; }

        public string TypeCreditNoteName { get; set; }
    }
}

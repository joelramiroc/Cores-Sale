namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CurrentAccountDocumentType
    {
        [Key]
        public long IdCurrentAccountDocumentType { get; set; }

        public string TypeName { get; set; }
    }
}

namespace CSales.Database.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Email
    {
        [Key]
        public long IdEmail { get; set; }

        public string Emaill { get; set; }
    }
}

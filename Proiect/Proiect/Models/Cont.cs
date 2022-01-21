using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Cont
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Doar litere, maxim = 40, minim = 3"), Required]
        public string Tip { get; set; }
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,3}$",
        ErrorMessage = "Doar litere, maxim = 3, minim = 3"), Required]
        public string Valuta { get; set; }
    }
}

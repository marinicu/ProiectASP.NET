using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name = "Nume Client")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Doar litere, maxim = 40, minim = 3"), Required]
        public string Nume { get; set; }
        [Display(Name = "Prenume Client")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{3,40}$",
         ErrorMessage = "Doar litere, maxim = 40, minim = 3"), Required]
        public string Prenume { get; set; }

        [RegularExpression(@"^[0-9''-'\s]{1,13}$",
          ErrorMessage = "Doar numere, 13 caractere obligatoriu"), Required]
        [Display(Name = "CNP Client")]       
        public string CNP { get; set; }

       
    }
}

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
        public string Nume { get; set; }
        [Display(Name = "Prenume Client")]
        public string Prenume { get; set; }
        [Display(Name = "CNP Client")]
        public string CNP { get; set; }

       
    }
}

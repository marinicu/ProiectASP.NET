using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Card
    {
        public int ID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public int ContID { get; set; }
        public Cont Cont { get; set; }
        public string TipCard { get; set; }
    }
}

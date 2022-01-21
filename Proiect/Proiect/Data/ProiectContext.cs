﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Client> Client { get; set; }       

        public DbSet<Proiect.Models.Cont> Cont { get; set; }

        public DbSet<Proiect.Models.Card> Card { get; set; }
       
    }
}

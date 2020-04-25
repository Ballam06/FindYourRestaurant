﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FindYourRestaurant.Models;
namespace FindYourRestaurant.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) { }

        public DbSet<Drug> Drug { get; set; }
        public DbSet<MainObject.Drug_Info> MainObject { get; set; }
    }
}

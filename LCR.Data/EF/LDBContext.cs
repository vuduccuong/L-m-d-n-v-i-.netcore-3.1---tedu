using LCR.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCR.Data.EF
{
    public class LDBContext : DbContext
    {
        public LDBContext(DbContextOptions options) : base(options)
        {
        }

        //Table
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

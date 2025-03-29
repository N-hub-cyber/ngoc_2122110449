
using leanhngoc_2122110449.model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace leanhngoc_2122110449.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
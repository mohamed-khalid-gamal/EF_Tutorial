using Microsoft.EntityFrameworkCore;
using Relations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations
{
    public class ApplpicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\carodb; database = EFcreedRelations ; Integrated Security = True ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasOne(b => b.blogImage).WithOne(i=>i.blog).HasForeignKey<BlogImage>(e=>e.BlogForeign);
           
        }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<BlogImage> blogImages { get; set; }
    }
}

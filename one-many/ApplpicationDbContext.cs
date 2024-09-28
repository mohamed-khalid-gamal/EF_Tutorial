using Microsoft.EntityFrameworkCore;
using one_many.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_many
{
    public class ApplpicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\carodb; database = EFcreedRelations ; Integrated Security = True ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Blog>().HasMany(e=>e.posts).WithOne();
            modelBuilder.Entity<Blog>()
                .HasMany<Post>()
                .WithOne()
                .HasForeignKey(e=>e.BlogId)
                .HasConstraintName("FK_BlogPost");
            modelBuilder.Entity<Car>()
                .HasMany(e => e.recordSales)
                .WithOne(e => e.car)
                .HasForeignKey(e => new {e.carLicense , e.carState})
                .HasPrincipalKey(e => new { e.Licencse , e.state});
            //modelBuilder.Entity<Post>()
            //    .HasMany(e => e.tags)
            //    .WithMany(e => e.posts)
            //    .UsingEntity(e => e.ToTable("PostsTagsTest"));
            modelBuilder.Entity<Post>()
                .HasMany(e => e.tags)
                .WithMany(e => e.posts)
                .UsingEntity<PostTag>(
                    j => j
                        .HasOne(e => e.tag)
                        .WithMany(e => e.postTags)
                        .HasForeignKey(e => e.TagId),
                    j => j
                        .HasOne(e => e.post)
                        .WithMany(e => e.postTags)
                        .HasForeignKey(e => e.PostId),
                    j =>
                    {
                        j.Property(e => e.AddedOn).HasDefaultValueSql("GETDATE()");
                        j.HasKey(e => new { e.PostId, e.TagId }); // Corrected syntax
                    }
                );
        }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Post> posts { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using reverse_engineering.Models;

namespace reverse_engineering.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<RecordSale> RecordSales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = (localdb)\\carodb; database = EFcreedRelations");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasOne(d => d.Blog).WithMany(p => p.Posts).HasConstraintName("FK_BlogPost");
        });

        modelBuilder.Entity<RecordSale>(entity =>
        {
            entity.HasOne(d => d.Car).WithMany(p => p.RecordSales)
                .HasPrincipalKey(p => new { p.Licencse, p.State })
                .HasForeignKey(d => new { d.CarLicense, d.CarState });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

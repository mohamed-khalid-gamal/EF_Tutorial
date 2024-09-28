using EF_Creed.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Creed
{
    public class ApplicationDbContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server = (localdb)\\carodb; database = EFcreed ; Integrated Security = True "); lazyloading
            //optionsBuilder.UseSqlServer("Server = (localdb)\\carodb; database = EFcreed ; Integrated Security = True " , o=>o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)); make query splitting is default
            optionsBuilder.UseSqlServer("Server = (localdb)\\carodb; database = EFcreed ; Integrated Security = True ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Post>(); // add the posts table
            //modelBuilder.Entity<Author>().Property(e => e.FullName).HasComputedColumnSql("[FirstName] + ' , ' + [LastName]"); // computing properety
            //modelBuilder.Ignore<Post>();    use it to not map the table or exclude it from mapped to database 
            //modelBuilder.Entity<Blog>().ToTable("Blogs",e => e.ExcludeFromMigrations()); exclude any thing happens in program from add it in migrations to apply to database
            //modelBuilder.Entity<Post>().ToTable("mypost");  rename the table name
            //modelBuilder.Entity<Post>().ToTable("myposts", schema: "log"); add table myposts to log schema
            //modelBuilder.Entity<Post>().Property(e=>e.Title).HasColumnName("PostTitle"); rename column
            //modelBuilder.Entity<Post>().Property(e=>e.Title).HasColumnType(typeName:"VarChar(200)") change type
            //modelBuilder.HasDefaultSchema("blogging"); add any new schema as default schema instead of dbo 
            //modelBuilder.Entity<Blog>().Property(b=>b.Name).HasMaxLength(100);
            //modelBuilder.Entity<Blog>().Property(e => e.Id).HasComment("pk of table");  add comment to the column
            //modelBuilder.Entity<Post>().HasKey(x => x.Id).HasName("pk_postID");  add primary key with constraints name pk_postId
            //modelBuilder.Entity<Post>().HasKey(x =>new { x.Id , x.Title}).HasName("pk_postID");  add composite primary key  
            //modelBuilder.Entity<Blog>().Property(e => e.Name).HasDefaultValue("Mo");  put default value to the column
            //modelBuilder.Entity<Blog>().Property(e => e.Name).HasDefaultValueSql("GetDate()");  put default sql command to the column
            //modelBuilder.Entity<Category>().Property(e => e.Id).ValueGeneratedOnAdd(); add value automatic every addition
            // modelBuilder.Entity<Blog>().HasIndex(e => e.Name); add index by column name
            //modelBuilder.Entity<Author>().HasIndex(e => new { e.FirstName, e.LastName });  add composite index
            //modelBuilder.Entity<Author>().HasIndex(e => e.FirstName).IsUnique();
            //modelBuilder.Entity<Author>().HasIndex(e => e.FirstName).IsUnique().HasFilter(null);
            //modelBuilder.Entity<Author>().HasIndex(e => e.FirstName).HasFilter("[FirstName IS NOT NULL]");

            //modelBuilder.HasSequence<int>("OrderNumber" , schema:"shared").IncrementsBy(5).StartsAt(5);
            //modelBuilder.Entity<Author>().Property(e => e.AuthorNum).HasDefaultValueSql("Next value for OrderNumber");

            //modelBuilder.Entity<Blog>().HasData(new Blog {Id = 1 , Name = "mo" });
            //modelBuilder.Entity<Post>().HasData(new Post {Id = 1 , Title = "mo" , BlogId = 1});

            //modelBuilder.Entity<Blog>().HasQueryFilter(p => p.post != null); add global filter
                }
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Author> authors { get; set; }
    }
}

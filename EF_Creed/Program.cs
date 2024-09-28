using EF_Creed.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Creed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add-migration nameOfMigration "dotnet ef migrations add nameOfMigration"
            //script-migration "dotnet ef migrations script"=> make sql script to all migrations
            //script-migration nameOfMigration "dotnet ef migrations script nameOfMigration" => make sql script after the migration to the end
            //script-migration nameOfMigration1 nameOfMigration2 "dotnet ef migrations script nameOfMigration1 nameOfMigration2"=> make sql script after migration1 to migration2 and 2 is included
            //get-migrations "dotnet ef migrations list" => List the migrations 
            //update-database "dotnet ef database update"=> apply all migrations 
            //update-database nameOfNigration "dotnet ef database update nameOfNigration" => apply all migrations to the selected migration
            //-------------------------------------------------------
            //_context.table.Find(PK) => retrive column with this PK
            //_context.table.All(condition) => retrive true if all rows match the condition
            //_context.table.Any() => retrive true if there exist any row in database
            //_context.table.Any(condition) => retrive true if there exist any row match condition 
            //_context.table.skip(number) => skip n rows and start after them
            //_context.table.take(number) => take n rows from start
            /*
                         ---------- inner Join --------------

             _context.table1
                .Join(
                    _context.table2
                    , table1 => table1.FK
                    , table2 => teble2.pk
                    , (table1 , table2 )=> new { the selected data from every table }
            
                ).Join(
                    _context.table3
                    , result => result.FK
                    , table3 => teble3.pk
                    , (result , table3 )=> new { the selected data from every table }
            
                ); 
            ---------------------------------------------------
            from emp in table1
            join dept in table2 on emp.id equals dept.id 
            join tech in table3 on dept.id equals tech.id
            select new {the selected data from every table}
            ---------- left Join --------------

            _context.table1
                .Join(
                    _context.table2
                    , table1 => table1.FK
                    , table2 => teble2.pk
                    , (table1 , table2 )=> new { the selected data from every table }
            
                ).GroupJoin(
                    _context.table3
                    , result => result.FK
                    , table3 => teble3.pk
                    , (result , table3 )=> new { res = result , table = table3 }
                )
                 .SelectMany(){
                        b=>b.table.DefaultIfEmpty(),
                        (b,n)=>new{b.res , n.table}
            
                        }; 

             */

            var _context = new ApplicationDbContext();
            // _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; remove tracking

            // var x =_context.authors.AsNoTracking().FirstOrDefault(e => e.Id == 1); // remove tracking 
            //var x =_context.blogs.Include(e=>e.post).FirstOrDefault(e => e.Id == 1); eager loading
            //_context.Entry(x).Reference(b => b.post).Load(); exceplict loading "load when i need it"
            //_context.Entry(x).Reference(b => b.post).Query().AnyQuery; exceplict loading "load when i need it and perform queries on  it"
            //_context.Entry(x).Collection(b => b.posts).Load(); exceplict loading "load collection from database when i need it"

            //var x =_context.blogs.Include(e=>e.post).AsSplitQuery().FirstOrDefault(e => e.Id == 1); // split query 
            // var x = _context.blogs.FromSqlRaw("Select * from blogs").ToList(); use raw sql to retrieve data
            //_context.blogs.IgnoreQueryFilters(); remove global filters that has been added in dbcontext
            // _context.blogs.AddRange(List of objects to be added)
            //_context.Entry(object that contains valued to be updated).Property(e => e.Name).IsModified = false; make the name property not modified

            /*using var trans = _context.Database.BeginTransaction();
            try
            {
                // process to execute must be save chnages after every query
                _context.blogs.Add(new Blog { });
                _context.SaveChanges();
                _context.blogs.Add(new Blog { });
                _context.SaveChanges();
                trans.Commit();
            }
            catch (Exception ex) {
            trans.Rollback();
            
            }*/
            // _context.Database.ExecuteSqlRaw("raw sql to delete or update or insert");
            //_context.Database.ExecuteSqlRaw("NameOfStoredProcedure @param = {...}");
            //_context.blogs.Where(b=>b.Id>10).ExecuteDelete(); // delete directly selected items
            //_context.blogs.Where(b=>b.Id>10).ExecuteUpdate(e=>e.SetProperety(b=>b.prop,valueToUpdate); // delete directly selected items


        }
    }
}

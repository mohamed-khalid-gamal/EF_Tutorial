using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Creed.Models
{
    //Index(nameof(FirstName),nameof(LastName))]  add composite index
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int AuthorNum { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
    }
}

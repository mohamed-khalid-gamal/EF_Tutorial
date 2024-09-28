using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Creed.Models
{
    //[Index(nameof(Name))] add index by column name
    //[Index(nameof(Name),IsUnique =true)] add index by column name and the index is unique
    public class Blog
    {
        //[Comment("primary key of table")] add comment to column
        public int Id { get; set; }
        //[Column("BlogName")]  rename column
        //[Column(TypeName ="VarChar(200)")] change type
        public string Name { get; set; }
        [ForeignKey("post")]
        public int postId { get; set; }
        public Post post { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Creed.Models
{
    //[Table("MoPosts")] rename the table name
    //[Table("MoPosts" ,Schema ="schema name" )] add table myposts to schema " schema name "
    public class Post
    {
        public int Id { get; set; }
        //[MaxLength(100)]  maximum length of string
        public string Title { get; set; }
        [ForeignKey("blog")]
        public int BlogId { get; set; }
        public Blog blog { get; set; }

    }
}

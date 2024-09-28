using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relations.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public BlogImage blogImage { get; set; }

    }
    public class BlogImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }
        public int BlogForeign { get; set; }
        public Blog blog { get; set; }
    }
}

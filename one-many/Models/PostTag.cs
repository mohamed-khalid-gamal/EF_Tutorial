using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_many.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public Post post { get; set; }
        public string TagId { get; set; }
        public Tag tag { get; set; }
        public DateTime AddedOn { get; set; }
    }
}

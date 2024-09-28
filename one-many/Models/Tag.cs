using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_many.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public List<Post> posts { get; set; }
        public List<PostTag> postTags { get; set; }

    }
}

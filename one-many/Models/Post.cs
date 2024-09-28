namespace one_many.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int BlogId { get; set; }
        public List<Tag> tags { get; set; }
        public List<PostTag> postTags { get; set; }
    }
}

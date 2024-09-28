using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace reverse_engineering.Models;

[Table("posts")]
[Index("BlogId", Name = "IX_posts_BlogId")]
public partial class Post
{
    [Key]
    public int Id { get; set; }

    [Column("title")]
    public string Title { get; set; } = null!;

    [Column("description")]
    public string Description { get; set; } = null!;

    public int BlogId { get; set; }

    [ForeignKey("BlogId")]
    [InverseProperty("Posts")]
    public virtual Blog Blog { get; set; } = null!;
}

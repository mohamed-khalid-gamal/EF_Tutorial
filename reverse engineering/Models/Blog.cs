using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace reverse_engineering.Models;

[Table("blogs")]
public partial class Blog
{
    [Key]
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    [InverseProperty("Blog")]
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}

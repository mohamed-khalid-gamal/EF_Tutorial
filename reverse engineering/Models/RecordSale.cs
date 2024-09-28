using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace reverse_engineering.Models;

[Table("RecordSale")]
[Index("CarLicense", "CarState", Name = "IX_RecordSale_carLicense_carState")]
public partial class RecordSale
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column("carLicense")]
    public string CarLicense { get; set; } = null!;

    [Column("carState")]
    public string CarState { get; set; } = null!;

    [ForeignKey("CarLicense, CarState")]
    [InverseProperty("RecordSales")]
    public virtual Car Car { get; set; } = null!;
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace reverse_engineering.Models;

[Table("Car")]
[Index("Licencse", "State", Name = "AK_Car_Licencse_state", IsUnique = true)]
public partial class Car
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Column("state")]
    public string State { get; set; } = null!;

    public string Licencse { get; set; } = null!;

    [InverseProperty("Car")]
    public virtual ICollection<RecordSale> RecordSales { get; set; } = new List<RecordSale>();
}

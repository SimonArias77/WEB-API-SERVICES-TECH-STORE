using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

[Table("orders")]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string? Name { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("creation_date")]
    public DateTime CreationDate { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }
}

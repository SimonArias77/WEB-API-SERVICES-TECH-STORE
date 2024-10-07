using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("categorie")]
    public string? Categorie { get; set; }

}

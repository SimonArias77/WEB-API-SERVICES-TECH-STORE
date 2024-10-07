using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

[Table("models")]
public class Category
{
   [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   [Column("id")]
   public int Id { get; set; }
   [Column("name")]
   public string? Name { get; set; }
   [Column("description")]
   public string? Description { get; set; }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

public class Order
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public int Quantity { get; set; }
    public string? State { get; set; }
    public DateTime CreationDate { get; set; }
    public int UserId { get; set; }
}

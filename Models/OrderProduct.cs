using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

    public class OrderProduct
    {
        public int Id {get; set;}
        public int OrderId {get; set;}
        public int ProductId {get; set;}
        public int Quantity {get; set;}
    }

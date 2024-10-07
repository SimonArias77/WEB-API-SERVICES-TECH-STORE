using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface IOrderProductRepository
{
    Task<IEnumerable<OrderProduct>> GetAll();
    Task<OrderProduct> GetById(int id);
    Task Add(OrderProduct orderProduct);
    Task Update(OrderProduct orderProduct);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}

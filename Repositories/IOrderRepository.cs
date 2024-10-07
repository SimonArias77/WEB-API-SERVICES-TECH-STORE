using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetAll();
    Task<Order> GetById(int id);
    Task Add(Order order);
    Task Update(Order order);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface IProductRepository
{

    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int id);
    Task Add(Product product);
    Task Update(Product product);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}

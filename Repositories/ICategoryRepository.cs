using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetAll();
    Task<Category> GetById(int id);
    Task Add(Category category);
    Task Update(Category category);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}

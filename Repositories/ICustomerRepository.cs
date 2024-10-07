using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAll();
    Task<Customer> GetById(int id);
    Task Add(Customer customer);
    Task Update(Customer customer);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}

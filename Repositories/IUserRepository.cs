

using CONSTRUCCION_AVANZADA_API_CON_.NET.Models;

namespace CONSTRUCCION_AVANZADA_API_CON_.NET.Repositories;

public interface IUserRepository
{

    Task<IEnumerable<User>> GetAll();
    Task<User> GetById(int id);
    Task Add(User user);
    Task Update(User user);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}

using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Interfases
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> AccountByUserName(string userName);
    }
}

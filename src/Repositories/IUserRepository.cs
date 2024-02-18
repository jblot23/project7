using Dot.Net.WebApi.Data;
using Dot.Net.WebApi.Domain;

namespace Dot.Net.WebApi.Repositories
{
    public interface IUserRepository
    {
        LocalDbContext DbContext { get; }

        void Add(User user);
        User[] FindAll();
        User FindById(int id);
        User FindByUserName(string userName);
    }
}
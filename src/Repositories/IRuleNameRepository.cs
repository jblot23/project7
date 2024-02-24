using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Domain;

namespace WebApi.Repositories
{
    public interface IRuleNameRepository
    {
        Task<List<RuleName>> GetAll();
        Task<RuleName> GetById(int id);
        Task Add(RuleName ruleName);
        Task Update(RuleName ruleName);
        Task Delete(int id);
    }
}

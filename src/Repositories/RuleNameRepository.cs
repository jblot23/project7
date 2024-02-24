using Dot.Net.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Domain;


namespace WebApi.Repositories
{
   
    public class RuleNameRepository : IRuleNameRepository
    {
        private readonly LocalDbContext _dbContext;

        public RuleNameRepository(LocalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<RuleName>> GetAll()
        {
            return await _dbContext.Rules.ToListAsync();
        }

        public async Task<RuleName> GetById(int id)
        {
            return await _dbContext.Rules.FindAsync(id);
        }

        public async Task Add(RuleName ruleName)
        {
            _dbContext.Rules.Add(ruleName);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(RuleName ruleName)
        {
            _dbContext.Entry(ruleName).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var ruleName = await _dbContext.Rules.FindAsync(id);
            if (ruleName != null)
            {
                _dbContext.Rules.Remove(ruleName);
                await _dbContext.SaveChangesAsync();
            }
        }
    }

}

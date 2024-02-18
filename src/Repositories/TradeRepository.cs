using Dot.Net.WebApi.Data;
using Dot.Net.WebApi.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Dot.Net.WebApi.Repositories
{
    public class TradeRepository : ITradeRepository
    {
        private readonly LocalDbContext _context;
        public TradeRepository(LocalDbContext context)
        {
            _context = context;
        }

        public List<Trade> GetAllTrades()
        {
            return _context.Trades.ToList();
        }

        public Trade FindTrade(int id)
        {
            return _context.Trades.Where(x => x.TradeId == id).FirstOrDefault();
        }

        public Trade AddTrade(Trade trade) 
        {
            _context.Trades.Add(trade);
            _context.SaveChanges();
            return trade;
        }

        public Trade UpdateTrade(Trade input) 
        {
            var trade = _context.Trades.FirstOrDefault(x => x.TradeId == input.TradeId);
            if (trade != null) 
            {
                _context.Trades.Update(trade);
                _context.SaveChanges(true);
            }
            return trade;
        }
    }
}

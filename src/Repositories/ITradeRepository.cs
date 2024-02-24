using Dot.Net.WebApi.Domain;
using System.Collections.Generic;

namespace Dot.Net.WebApi.Repositories
{
    public interface ITradeRepository
    {
        Trade AddTrade(Trade trade);
        bool DeleteTrade(int id);
        Trade FindTrade(int id);
        List<Trade> GetAllTrades();
        Trade UpdateTrade(int tradeId, Trade input);
    }
}
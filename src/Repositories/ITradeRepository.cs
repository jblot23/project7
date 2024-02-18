using Dot.Net.WebApi.Domain;
using System.Collections.Generic;

namespace Dot.Net.WebApi.Repositories
{
    public interface ITradeRepository
    {
        Trade AddTrade(Trade trade);
        Trade FindTrade(int id);
        List<Trade> GetAllTrades();
        Trade UpdateTrade(Trade input);
    }
}
using Dot.Net.WebApi.Domain;
using System.Collections.Generic;

namespace WebApi.Repositories
{
    public interface IBidListRepository
    {
        BidList GetById(int id);
        IEnumerable<BidList> GetAll();
        void Add(BidList bidList);
        void Update(BidList bidList);
        void Delete(int id);
        void SaveChanges();

    }
}

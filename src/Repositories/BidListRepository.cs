using Dot.Net.WebApi.Data;
using Dot.Net.WebApi.Domain;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Repositories
{
    public class BidListRepository : IBidListRepository
    {
        private readonly LocalDbContext _context;

        public BidListRepository(LocalDbContext context)
        {
            _context = context;
        }

        public BidList GetById(int id)
        {
            return _context.Bids.Find(id);
        }

        public IEnumerable<BidList> GetAll()
        {
            return _context.Bids.ToList();
        }

        public void Add(BidList bidList)
        {
            _context.Bids.Add(bidList);
        }

        public void Update(BidList bidList)
        {
            _context.Bids.Update(bidList);
        }

        public void Delete(int id)
        {
            var bidList = _context.Bids.Find(id);
            if (bidList != null)
            {
                _context.Bids.Remove(bidList);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }

}

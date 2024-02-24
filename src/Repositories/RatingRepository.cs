using Dot.Net.WebApi.Controllers.Domain;
using Dot.Net.WebApi.Data;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly LocalDbContext _dbContext;

        public RatingRepository(LocalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Rating GetById(int id)
        {
            return _dbContext.Rating.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Rating> GetAll()
        {
            return _dbContext.Rating.ToList();
        }

        public void Add(Rating rating)
        {
            _dbContext.Rating.Add(rating);
            _dbContext.SaveChanges();
        }

        public void Update(Rating rating)
        {
            _dbContext.Rating.Update(rating);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var ratingToRemove = GetById(id);
            if (ratingToRemove != null)
            {
                _dbContext.Rating.Remove(ratingToRemove);
                _dbContext.SaveChanges();
            }
        }
    }
}

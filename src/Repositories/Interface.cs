using Dot.Net.WebApi.Controllers.Domain;
using System.Collections.Generic;

namespace WebApi.Repositories
{
    public interface IRatingRepository
    {
        Rating GetById(int id);
        IEnumerable<Rating> GetAll();
        void Add(Rating rating);
        void Update(Rating rating);
        void Delete(int id);
    }
}

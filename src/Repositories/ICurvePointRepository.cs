using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dot.Net.WebApi.Domain
{
    public interface ICurvePointRepository
    {
        Task AddAsync(CurvePoint curvePoint);
        Task DeleteAsync(int id);
        Task<List<CurvePoint>> GetAllAsync();
        Task<CurvePoint> GetByIdAsync(int id);
        Task UpdateAsync(CurvePoint curvePoint);
    }
}
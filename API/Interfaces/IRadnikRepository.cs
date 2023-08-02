using System.Linq.Expressions;
using API.Entities;

namespace API.Interfaces
{
    public interface IRadnikRepository
    {
        Task<List<TProjection>> GetRadnici<TProjection>(Expression<Func<Radnik, TProjection>> selector);
        Task<Radnik> GetRadnik(int id);
    }
}
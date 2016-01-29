using System.Linq;

namespace AgileCamp.HabTests
{
    public interface IDbContext
    {
        IQueryable<T> Query<T>();
    }
}
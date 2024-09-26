using System.Collections.ObjectModel;

namespace Lesson11.Servises.Repositories
{
    public interface IRepository<T, TId>
    {
        int Add(T item);
        int Update(T item);
        T GetById(TId id);
        List<T> GetAll();
        int Delete(TId id);
    }
}

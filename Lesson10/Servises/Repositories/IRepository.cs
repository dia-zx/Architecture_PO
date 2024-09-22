using System.Collections.ObjectModel;

namespace Lesson10.Servises.Repositories
{
    public interface IRepository<T, TId>
    {
        int Add(T item);
        int Update(T item, TId id);
        T GetById(TId id);
        Collection<T> GetAll();
        int Delete(TId id);
    }
}

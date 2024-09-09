using DomainModels;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T : BaseClass
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        int Update(T entity);
        int Remove(int id);
    }
}

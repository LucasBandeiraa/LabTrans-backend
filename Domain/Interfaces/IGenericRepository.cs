
namespace Domain.Interfaces
{
   public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetAllUsersWallets(int userId);
        IQueryable<T> List();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

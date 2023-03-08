namespace Repository.IGenericRepository {
    public interface IGenericRepository<T> where T: class {
        Task<IEnumerable<T>> GetAll();
        Task<T?> Get(long id);
        Task<T?> Add(T entity);
        Task<T> Update(T entity);
        Task<T?> Delete(long id);
    }
}
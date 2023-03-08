using BackEnd_CSharp.Models;

namespace Services.Interfaces {
    public interface IGenericServices<T> {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(long id);
        Task<T> New(T entity);
        Task<T> Update(T entity);
        Task<T?> Delete(long id);
        Task<Note?> New(Note newNote);
    }
}
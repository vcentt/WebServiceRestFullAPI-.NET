
using BackEnd_CSharp.Models;
using Repository.IGenericRepository;
using Services.Interfaces;

namespace Services {
    public class GenericServices<T>: IGenericServices<T> where T: class{

        private readonly IGenericRepository<T> _genericRepository;
        public GenericServices(IGenericRepository<T> genericRepository){
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<T>> GetAll(){
            return await _genericRepository.GetAll();
        }

        public async Task<T?> GetById(long id){
            return await _genericRepository.Get(id);
        }

        public async Task<T?> New(T entity){
            return await _genericRepository.Add(entity);
        }

        public async Task<T> Update(T entity){
            return await _genericRepository.Update(entity);
        }

        public async Task<T?> Delete(long id){
            return await _genericRepository.Delete(id);
        }

        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<T>> IGenericServices<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<T?> IGenericServices<T>.GetById(long id)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericServices<T>.New(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T> IGenericServices<T>.Update(T entity)
        {
            throw new NotImplementedException();
        }

        Task<T?> IGenericServices<T>.Delete(long id)
        {
            throw new NotImplementedException();
        }

        Task<Note?> IGenericServices<T>.New(Note newNote)
        {
            throw new NotImplementedException();
        }
    }
}
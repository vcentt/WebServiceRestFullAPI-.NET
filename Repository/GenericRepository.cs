using BackEnd_CSharp.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IGenericRepository;

namespace Repository {
    public class GenericRepository<T>: IGenericRepository<T> where T: class {
        private readonly NortnotesContext _context;

        //Constructor assing context
        public GenericRepository(NortnotesContext context){
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll(){
            // Execute my query Generic and return it
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> Get(long id){
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T?> Add(T entity){
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity){
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T?> Delete(long id){

            var entity = await _context.Set<T>().FindAsync(id);
            if(entity is null) return entity;

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
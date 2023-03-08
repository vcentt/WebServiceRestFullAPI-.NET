using BackEnd_CSharp.Models;
using Repository.IGenericRepository;
using Services.Interfaces;

namespace Services {
    public class NotesService: INotesServices {
        private readonly IGenericRepository<Note> _notesRepository;
        
        // Dependency Injection Constructor
        public NotesService(IGenericRepository<Note> notesRepository){
            _notesRepository = notesRepository;
        }

        // Methods
        public async Task<IEnumerable<Note>> GetAll(){
            return await _notesRepository.GetAll();
        }

        public async Task<Note?> GetById(long id){
            return await _notesRepository.Get(id);
        }

        public async Task<Note?> New(Note newNote){
            return await _notesRepository.Add(newNote);
        }

        public async Task<Note> Update(Note updateNote){
            return await _notesRepository.Update(updateNote);
        }

        public async Task<Note?> Delete(long id){
            return await _notesRepository.Delete(id);
        }
    }
}
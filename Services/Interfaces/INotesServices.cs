using BackEnd_CSharp.Models;

namespace Services.Interfaces {
    public interface INotesServices {
        Task<IEnumerable<Note>> GetAll();
        Task<Note?> GetById(long id);
        Task<Note?> New(Note newNote);
        Task<Note> Update(Note updateNote);
        Task<Note?> Delete(long id);
    }
};
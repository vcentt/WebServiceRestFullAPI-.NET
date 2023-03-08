using BackEnd_CSharp.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace BackEnd_CSharp.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesControllers : ControllerBase {

    private readonly ILogger<NotesControllers> _logger;
    private readonly IGenericServices<Note> _notesServices;
    public NotesControllers(ILogger<NotesControllers> logger, IGenericServices<Note> notesServices){
        _logger = logger;
        _notesServices = notesServices;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Note>> GetAll(){
        try{
            return await _notesServices.GetAll();
        }catch(Exception e){
            throw new Exception(e.ToString());
        }
    }

    [HttpGet]
    [Route ("{id}")]
    public async Task<Note?> GetById(long id){
        try{
            return await _notesServices.GetById(id);
        }catch(Exception e){
            throw new Exception(e.ToString());
        }
    }

    [HttpPost]
    public async Task<Note?> New([FromBody] Note newNote){
        try{
            return await _notesServices.New(newNote);
        }catch(Exception e){
            throw new Exception(e.ToString());
        }
    }

    [HttpPut]
    public async Task<Note> Update([FromBody] Note updateNote){
        try{
            return await _notesServices.Update(updateNote);
        }catch(Exception e){
            throw new Exception(e.ToString());
        }
    }

    [HttpDelete]
    [Route ("{id}")]
    public async Task<Note?> Delete(long id){
        try{
            return await _notesServices.Delete(id);
        }catch(Exception e){
            throw new Exception(e.ToString());
        }
    }
}

// Create data structure with tree searching
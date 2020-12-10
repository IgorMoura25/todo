using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todo.Data;
using Todo.Data.Interfaces;
using Todo.Models.Entities.Note;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class NoteController : ControllerBase
    {
        private INoteDao _noteDao { get; }
        public NoteController(INoteDao noteDao)
        {
            _noteDao = noteDao;
        }

        [HttpGet("note/{noteId}")]
        public GetNoteByIdResponseModel GetNoteById(long noteId)
        {
            var note = _noteDao.GetNoteById(new GetNoteByIdRequestModel() { NoteId = noteId });
            return note;
        }

        [HttpGet("note/types")]
        public List<ListNoteTypesResponseModel> ListNoteTypes()
        {
            var noteTypes = _noteDao.ListNoteTypes();
            return noteTypes;
        }

        [HttpGet("notes")]
        public List<ListNotesResponseModel> ListNotes()
        {
            var notes = _noteDao.ListNotes();
            return notes;
        }
    }
}

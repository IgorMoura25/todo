using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.Data.Interfaces;
using Todo.Models;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("note")]
    public class NoteController : ControllerBase
    {
        private INoteDao _noteDao;
        public NoteController(INoteDao noteDao)
        {
            _noteDao = noteDao;
        }

        [HttpGet("types")]
        public List<ListNoteTypesResponseModel> ListNoteTypes()
        {
            //TODO: Remover hardcode
            return new List<ListNoteTypesResponseModel>() {
                new ListNoteTypesResponseModel() { NoteTypeId = 1, Name = "Lista" },
                new ListNoteTypesResponseModel() { NoteTypeId = 2, Name = "Texto" },
            };
        }
        [HttpGet("notes")]
        public IEnumerable<Note> ListNotes()
        {
            var notes = _noteDao.GetAllNotes();
            return notes;
        }

    }
}

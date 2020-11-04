using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.Models.Note;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("note")]
    public class NoteController : ControllerBase
    {
        [HttpGet("types")]
        public List<ListNoteTypesResponseModel> ListNoteTypes()
        {
            //TODO: Remover hardcode
            return new List<ListNoteTypesResponseModel>() { 
                new ListNoteTypesResponseModel() { NoteTypeId = 1, Name = "Lista" },
                new ListNoteTypesResponseModel() { NoteTypeId = 2, Name = "Texto" },
            };
        }
    }
}

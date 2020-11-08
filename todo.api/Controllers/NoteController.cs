using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.Data;
using Todo.Data.Interfaces;
using Todo.Models;
using Todo.Models.Note;

namespace Todo.Api.Controllers
{
	[ApiController]
	[Route("")]
	public class NoteController : ControllerBase
	{
		private NoteDao _noteDao { get; }
		public NoteController(NoteDao noteDao)
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

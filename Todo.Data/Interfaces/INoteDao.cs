using System;
using System.Collections.Generic;
using System.Text;
using Todo.Models.Entities.Note;

namespace Todo.Data.Interfaces
{
	public interface INoteDao
	{
		GetNoteByIdResponseModel GetNoteById(GetNoteByIdRequestModel model);
		List<ListNoteTypesResponseModel> ListNoteTypes();
		List<ListNotesResponseModel> ListNotes();

	}
}

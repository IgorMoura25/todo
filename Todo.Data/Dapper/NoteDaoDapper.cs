using System.Collections.Generic;
using Todo.Data.Interfaces;
using Todo.Models.Entities.Note;

namespace Todo.Data.Dapper
{
	public class NoteDaoDapper : DataBaseOperationsDapper, INoteDao
	{
		public GetNoteByIdResponseModel GetNoteById(GetNoteByIdRequestModel model)
		{
			return Get<GetNoteByIdResponseModel>("SP_TD_GET_NoteById", model);
		}

		public List<ListNotesResponseModel> ListNotes()
		{
			return List<ListNotesResponseModel>("SP_TD_LST_Notes");
		}

		public List<ListNoteTypesResponseModel> ListNoteTypes()
		{
			return List<ListNoteTypesResponseModel>("SP_TD_LST_NoteTypes");
		}
	}
}

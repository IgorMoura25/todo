using System.Collections.Generic;
using Todo.Data.Interfaces;
using Todo.Models.Entities.Note;

namespace Todo.Data.Mocks
{
	public class NoteDaoMock : INoteDao
	{
		public GetNoteByIdResponseModel GetNoteById(GetNoteByIdRequestModel model)
		{
			return new GetNoteByIdResponseModel();
		}

		public List<ListNotesResponseModel> ListNotes()
		{
			return new List<ListNotesResponseModel>();
		}

		public List<ListNoteTypesResponseModel> ListNoteTypes()
		{
			return new List<ListNoteTypesResponseModel>();
		}
	}
}

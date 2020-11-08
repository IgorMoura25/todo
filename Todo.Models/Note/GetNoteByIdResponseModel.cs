using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models.Note
{
	public class GetNoteByIdResponseModel
	{
		public long NoteId { get; set; }
		public NoteTypeEnum NoteTypeId { get; set; }
		public string Title { get; set; }
	}
}

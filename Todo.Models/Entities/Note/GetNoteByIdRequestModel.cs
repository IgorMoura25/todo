using System;
using System.Collections.Generic;
using System.Text;
using Todo.Models.Base;

namespace Todo.Models.Entities.Note
{
	public class GetNoteByIdRequestModel : GetRequestModel
	{
		public long NoteId { get; set; }
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models.Note
{
    public class ListNoteTypesResponseModel
    {
        public NoteTypeEnum NoteTypeId { get; set; }
        public string Name { get; set; }
    }
}

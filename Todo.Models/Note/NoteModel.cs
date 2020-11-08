using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Models
{
    public class NoteModel
    {
        public long NoteId { get; set; }
        public long NoteTypeId { get; set; }
        public string Title { get; set; }
    }
}

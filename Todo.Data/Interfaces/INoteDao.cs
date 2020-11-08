using System.Collections.Generic;
using Todo.Models;

namespace Todo.Data.Interfaces
{
    public interface INoteDao
    {
        void Save(NoteModel note);
        IEnumerable<NoteModel> GetAllNotes();
    }
}

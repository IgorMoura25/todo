using Todo.Models.Enums;

namespace Todo.Models.Entities.Note
{
    public class GetNoteByIdResponseModel
    {
        public long NoteId { get; set; }
        public NoteTypeEnum NoteTypeId { get; set; }
        public string Title { get; set; }
    }
}

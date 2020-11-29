using Todo.Models.Enums;

namespace Todo.Models.Entities.Note
{
    public class ListNoteTypesResponseModel
    {
        public NoteTypeEnum NoteTypeId { get; set; }
        public string Name { get; set; }
    }
}

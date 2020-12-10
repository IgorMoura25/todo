using System.Collections.Generic;
using Todo.Data.Interfaces;
using Todo.Models.Entities.Note;

namespace Todo.Data.Dapper
{
    public class NoteDaoDapper : DataBaseOperationsDapper, INoteDao
    {
        public NoteDaoDapper(string connectionString) : base(connectionString)
        {

        }

        public GetNoteByIdResponseModel GetNoteById(GetNoteByIdRequestModel model)
        {
            return Get<GetNoteByIdResponseModel>("SP_TD_GET_NoteById", model);
        }

        public List<ListNotesResponseModel> ListNotes()
        {
            return List<ListNotesResponseModel>("select * from Notes");
        }

        public List<ListNoteTypesResponseModel> ListNoteTypes()
        {
            return List<ListNoteTypesResponseModel>("select * from NoteTypes");
        }
    }
}

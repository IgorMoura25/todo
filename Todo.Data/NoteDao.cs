using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Todo.Data.Interfaces;
using Todo.Models;

namespace Todo.Data
{
    public class NoteDao : INoteDao
    {
        private readonly string _connectionString = @"server=localhost\SQLEXPRESS;database=todo;user=sa;password=123@mudar";

        public IEnumerable<NoteModel> GetAllNotes()
        {
            var connection = new SqlConnection(_connectionString);
            var notes = connection.Query<NoteModel>("SELECT * FROM Notes");
            return notes;
        }

        public void Save(NoteModel note)
        {

        }
    }
}

using System;
using Todo.Data.Interfaces;
using Xunit;
using Todo.Models.Entities.Note;

namespace Todo.Tests.Todo.Data
{
	public class TodoDataNoteDaoTests
	{
		private readonly INoteDao _noteDao;
		public TodoDataNoteDaoTests(INoteDao noteDao)
		{
			_noteDao = noteDao;
		}

		[Fact]
		public void GetNoteByIdTest()
		{
			Random random = new Random();
			var id = random.Next(1, 5); //generate random int from 1 to 4
			var note = _noteDao.GetNoteById(new GetNoteByIdRequestModel { NoteId = id });
			Assert.NotNull(note);
			Assert.IsType<GetNoteByIdResponseModel>(note);
		}
	}
}

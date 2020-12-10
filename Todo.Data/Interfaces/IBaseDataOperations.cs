using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Todo.Models.Base;

namespace Todo.Data.Interfaces
{
	interface IBaseDataOperations
	{
		string ConnectionString();

		SqlConnection NewConnection(); //TODO: tentar tirar isso daqui, ou daqui para baixo kk

		T Get<T>(string query, GetRequestModel param);

		List<T> List<T>(string query);
	}
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Todo.Models.Base;

namespace Todo.Data.Interfaces
{
	interface ISqlConnection
	{
		SqlConnection NewConnection();
		T Get<T>(string query, GetRequestModel param);
		List<T> List<T>(string query);
	}
}

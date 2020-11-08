using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Todo.Data.Interfaces
{
	interface ISqlConnection
	{
		SqlConnection NewConnection();
		List<T> List<T>(string query);
	}
}

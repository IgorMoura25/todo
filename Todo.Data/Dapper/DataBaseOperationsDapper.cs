using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Todo.Models.Base;

namespace Todo.Data.Dapper
{
	public abstract class DataBaseOperationsDapper
	{
		protected string _connectionString = System.Environment.GetEnvironmentVariable("TODO_API_CONNECTION_STRING");

		public SqlConnection NewConnection()
		{
			var sqlConnection = new SqlConnection(this._connectionString);
			sqlConnection.Open();
			return sqlConnection;
		}

		public T Get<T>(string query, GetRequestModel param)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.QuerySingleOrDefault<T>(query, param, commandType: CommandType.StoredProcedure);
				return result;
			}
		}

		public List<T> List<T>(string query)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.Query<T>(query);
				var objectList = result != null ? result.ToList<T>() : null;
				return objectList;
			}
		}
	}
}

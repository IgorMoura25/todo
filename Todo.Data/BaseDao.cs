using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Todo.Data.Interfaces;
using Todo.Models.Base;

namespace Todo.Data
{
	public abstract class BaseDao : ISqlConnection
	{
		protected string ConnectionString { get; set; }

		public BaseDao(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		public SqlConnection NewConnection()
		{
			var sqlConnection = new SqlConnection(this.ConnectionString);
			sqlConnection.Open();
			return sqlConnection;
		}

		public T Get<T>(string query, GetRequestModel param)
		{
			var connection = this.NewConnection();
			var result = connection.QuerySingleOrDefault<T>(query, param, commandType: CommandType.StoredProcedure); //TODO: Descomentar quando a query for stored procedure
			return result;
		}

		public List<T> List<T>(string query)
		{
			var connection = this.NewConnection();
			var result = connection.Query<T>(query);
			var objectList = result != null ? result.ToList<T>() : null;
			return objectList;
		}
	}
}

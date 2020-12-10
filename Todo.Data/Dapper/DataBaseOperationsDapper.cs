using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Todo.Data.Interfaces;
using Todo.Models.Base;

namespace Todo.Data.Dapper
{
	public abstract class DataBaseOperationsDapper
	{
		protected string ConnectionString { get; set; } //TODO: carregar a connection string do environment

		public DataBaseOperationsDapper(string connectionString)
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
			throw new System.NotImplementedException();
		}

		public List<T> List<T>(string query)
		{
			throw new System.NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Configuration
{
	public interface IApiConfiguration
	{
		string ConnectionString { get; }
	}
}

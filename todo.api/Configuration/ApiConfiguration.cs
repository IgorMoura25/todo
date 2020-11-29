using System;

namespace Todo.Api.Configuration
{
    public class ApiConfiguration : IApiConfiguration
    {
        public string ConnectionString { get; }

        public ApiConfiguration()
        {
            ConnectionString = ReadVariableString("TODO_API_CONNECTION_STRING");
        }

        private string ReadVariableString(string variableName)
        {
            var environmentVariable = Environment.GetEnvironmentVariable(variableName);

            //TODO: Tratar se não encontrar

            return environmentVariable;
        }
    }
}

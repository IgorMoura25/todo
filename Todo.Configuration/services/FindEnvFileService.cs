using System.IO;
using System.Linq;

namespace Todo.Configuration.services
{
	public static class FindEnvFileService
	{
		public static DirectoryInfo TryGetEnvDirectoryInfo(string currentPath = null)
		{
			var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
			while (directory != null && !directory.GetFiles("*.env").Any())
			{
				directory = directory.Parent;
			}
			return directory;
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Api.Controllers
{
	[Route("[Controller]")]
	public class TestController : ControllerBase
	{
		[Route("[Action]")]
		public string CommitHash()
		{
			return Properties.Resources.CurrentCommit;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects
{
	public class UserAction (string user, string description)
	{
		public DateTime CreateDateTime { get; } = DateTime.Now;

		public string User => user;
		public string Description => description;
	}
}

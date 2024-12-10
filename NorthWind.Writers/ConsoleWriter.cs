namespace NorthWind.Writers
{
	public class ConsoleWriter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
				action.CreateDateTime, action.User, action.Description);
		}
	}
}

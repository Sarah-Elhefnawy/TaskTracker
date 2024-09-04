namespace TaskTracker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Welcome user
			//1. Add Task
			//2. View all tasks
			//3. Mark task complete
			//4.  task
			//5. Exit

			Console.WriteLine("Welcome to my task tracker");
			Console.WriteLine("Enter your choice from 1 to 5");

			string userChoice = Console.ReadLine();

			switch (userChoice)
			{
				case "1":

					AddTask();
					break;
				case "2":


					break;
				case "3":


					break;
				case "4":


					break;
				case "5":


					break;
				default:
					Console.WriteLine("Please enter number from 1 to 5 only");
					break;
			}

			
		}
		private static void AddTask()
		{
			Console.WriteLine("Enter task title");
		}
	}
}

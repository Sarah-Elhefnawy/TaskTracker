using System.Collections;

namespace TaskTracker
{
	internal class Program
	{
		static string[] tasks = new string[100];

		static int taskIndex = 0;
		static void Main(string[] args)
		{
			//Welcome user
			//1. Add Task
			//2. View all tasks
			//3. Mark task complete
			//4.  task
			//5. Exit

			Console.WriteLine("Welcome to my task tracker");
			Console.WriteLine("------------------------");


			while (true)
			{
				Console.WriteLine("Enter your choice from 1 to 5");
				Console.WriteLine("1. Add");
				Console.WriteLine("2. View");
				Console.WriteLine("3. Complete");
				Console.WriteLine("4. Remove");
				Console.WriteLine("5. Exit");


				string userChoice = Console.ReadLine();

				switch (userChoice)
				{
					case "1":
						AddTask();
						break;
					case "2":
						ViewTasks();
						break;
					case "3":
						MarkComplete();
						break;
					case "4":
						DeleteTask();
						break;
					case "5":
						Environment.Exit(0);
						/*
						 * Environment is a class that contain Exit method
						 * this way the loop ends
						*/
						break;
					default:
						Console.WriteLine("Please enter number from 1 to 5 only");
						break;
				}
			}
		}
		private static void AddTask()
		{
			Console.WriteLine("Enter task title");
			string taskTitle = Console.ReadLine();

			tasks[taskIndex] = taskTitle;
			Console.WriteLine("Task added");

			taskIndex++;
		}
		private static void ViewTasks()
		{
			Console.WriteLine("Task list: ");

            for (int i = 0; i < taskIndex; i++)
            {
				if(taskIndex==0)
					Console.WriteLine($"{i + 1}. Task Index is Empty!!");
				else
					Console.WriteLine($"{i + 1}. Task title is: {tasks[i]}");
			}
        }
		private static void MarkComplete()
		{
			Console.WriteLine("Enter task number: ");

			int taskNumber = Convert.ToInt32(Console.ReadLine()) - 1;

			int taskId = Convert.ToInt32(taskNumber);

			tasks[taskId] = tasks[taskId] + "--COMPLETED";
		}
		private static void DeleteTask()
		{
			Console.WriteLine("Enter task number to delete: ");

			int taskId = Convert.ToInt32(Console.ReadLine()) -1;

			//tasks[taskId] = "";
			tasks[taskId] = string.Empty;
		}
	}
}

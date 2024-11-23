using System.Collections.ObjectModel;

namespace trpo5
{
    public class Program
    {

        public static ObservableCollection<SimpleTask> Tasks = new();

        private static string _newTaskTitle;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название задачи (введите end для завершения):");
                _newTaskTitle = Console.ReadLine();

                if (_newTaskTitle == "end")
                    return;

                var taskFactory = new SimpleTaskFactory(_newTaskTitle);
                taskFactory.AddTask();

                DisplayTasks();
            }
        }

        private static void DisplayTasks()
        {
            Console.WriteLine();
            foreach (var simpleTask in Tasks)
            {
                Console.WriteLine($"{simpleTask.Title}. Статус выполнения задачи - {simpleTask.IsCompleted}");
            }

            Console.WriteLine();
        }
    }
}
using System.Collections.ObjectModel;

namespace trpo5
{
    public class Program
    {
        public static string _newTaskTitle;

        private static string NewTaskTitle
        {
            get => _newTaskTitle;
            set => _newTaskTitle = value;
        }

        public static ObservableCollection<SimpleTask> Tasks = new();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название задачи (введите end для завершения):");
                NewTaskTitle = Console.ReadLine();

                if (NewTaskTitle == "end")
                    return;

                var taskFactory = new SimpleTaskFactory(NewTaskTitle);
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
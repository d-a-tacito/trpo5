using System.Collections.ObjectModel;

namespace trpo5
{
    public class Program
    {
        public static string _newTaskTitle;

        public static ObservableCollection<SimpleTask> Tasks = new();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите название задачи (введите end для завершения):");
                _newTaskTitle = Console.ReadLine();

                if (_newTaskTitle == "end")
                    return;
                
                AddTask();

                Console.WriteLine();
                foreach (var simpleTask in Tasks)
                {
                    Console.WriteLine($"{simpleTask.Title}. Статус выполнения задачи - {simpleTask.IsCompleted}");
                }
                Console.WriteLine();
            }
        }

        public static void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(_newTaskTitle))
            {
                AddTaskInternal(_newTaskTitle);
                _newTaskTitle = string.Empty;
            }
        }

        private static void AddTaskInternal(string taskTitle)
        {
            Tasks.Add(new SimpleTask { Title = taskTitle });
        }

    }
}
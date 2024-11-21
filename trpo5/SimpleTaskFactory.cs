namespace trpo5;
public class SimpleTaskFactory
{
    private string _taskTitle;

    public SimpleTaskFactory(string taskTitle)
    {
        _taskTitle = taskTitle;
    }

    public void AddTask()
    {
        if (!string.IsNullOrWhiteSpace(_taskTitle))
        {
            Program.Tasks.Add(new SimpleTask { Title = _taskTitle });
            _taskTitle = string.Empty;
        }
    }
}

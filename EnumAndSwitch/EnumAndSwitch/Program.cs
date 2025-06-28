internal class Program
{
    private static void Main(string[] args)
    {
        List<Todo> todos = new List<Todo>()
        {
            new Todo { Description = "Task A", EstimatedHours = 12, Status = Status.NotStarted},
            new Todo { Description = "Task B", EstimatedHours = 2, Status = Status.InProgress},
            new Todo { Description = "Task C", EstimatedHours = 5, Status = Status.Completed},
            new Todo { Description = "Task D", EstimatedHours = 6, Status = Status.Deleted}
        };

        PrintAssessment(todos);
        Console.ReadLine();
    }

    private static void PrintAssessment(List<Todo> Todos)
    {
        foreach (Todo todo in Todos)
        {
            switch (todo.Status)
            {
                case Status.Completed:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Status.InProgress:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Status.NotStarted:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case Status.Deleted:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Status: {0}, Description: {1}", todo.Status, todo.Description);
        }
    }

    private class Todo
    {
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
        public string? Description { get; set; }
    }

    enum Status
    {
        Completed,
        InProgress,
        NotStarted,
        Deleted
    }


}
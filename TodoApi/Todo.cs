namespace TodoApi
{
    public class Todo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
    }
}

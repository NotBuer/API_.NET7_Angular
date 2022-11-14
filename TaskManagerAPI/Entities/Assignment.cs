namespace TaskManagerAPI.Entities
{
    public class Assignment : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool Done { get; set; }
    }
}

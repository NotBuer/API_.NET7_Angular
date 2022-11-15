namespace TaskManagerAPI.Entities
{
    public class Assignment : IEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public bool Done { get; set; }
    }
}

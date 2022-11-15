namespace TaskManagerAPI.Repositories.Interfaces
{
    public interface IAssignment
    {
        Task Create(Assignment assignment);
        void Update(Assignment assignment);
        Task Delete(int id);

        Task<List<Assignment>> GetAllAssignments();
        Task<Assignment?> GetAssignmentById(int id);
    }
}

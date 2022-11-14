namespace TaskManagerAPI.Repositories.Implementations
{
    public class AssignmentRepository : IAssignment
    {
        private readonly AppDbContext _context;

        public AssignmentRepository(AppDbContext context) => _context = context; 


        public async Task Create(Assignment assignment)
        {
            await _context.Assignments.AddAsync(assignment);
        }

        public async Task Update(Assignment assignment)
        {
             _context.Assignments.Update(assignment);
        }

        public async Task Delete(int id)
        {
            var assignment = _context.Assignments.Attach(new Assignment { Id = id });
            assignment.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<List<Assignment>> GetAllAssignments()
        {
            return await _context.Assignments.ToListAsync();
        }

        public async Task<Assignment> GetAssignmentById(int id)
        {
            return await _context.Assignments.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}

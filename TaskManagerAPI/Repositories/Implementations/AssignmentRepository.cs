namespace TaskManagerAPI.Repositories.Implementations
{
    public class AssignmentRepository : IAssignment
    {
        private readonly AppDbContext _context;

        public AssignmentRepository(AppDbContext context) => _context = context;


        public async Task Create(Assignment assignment)
        {
            await _context.Assignments.AddAsync(assignment);
            await _context.SaveChangesAsync();
        }

        public void Update(Assignment assignment)
        {
            _context.Assignments.Update(assignment);
            _context.SaveChanges();
        }

        public async Task Delete(int id)
        {
            Assignment? assignment = await _context.Assignments.FirstOrDefaultAsync(x => x.Id == id);
            if (assignment != null)
            {
                _context.Assignments.Remove(assignment);
                _context.SaveChanges();
            }
        }

        public async Task<List<Assignment>> GetAllAssignments()
        {
            return await _context.Assignments.ToListAsync();
        }

        public async Task<Assignment?> GetAssignmentById(int id)
        {
            return await _context.Assignments.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}

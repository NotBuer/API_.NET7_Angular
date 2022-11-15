using Utils = TaskManagerAPI.Utility.EndPointsUtils;

namespace TaskManagerAPI.Endpoints
{
    public static class EndpointsMapping
    {
        
        public static void MapEndpoints(this WebApplication app)
        {
            AssignmentsEndpoints(app);
        }

        private static void AssignmentsEndpoints(this WebApplication app)
        {
            app.MapPost(Utils.ROUTE_Assignment_POST, async (AssignmentRepository _repository, Assignment assignment) =>
            {
                await _repository.Create(assignment);
                return Results.Created(Utils.ROUTE_Assignment_POST, assignment);
            })
                .Produces<Assignment>(StatusCodes.Status201Created)
                .WithName("CreateAssignment")
                .WithTags("Assignment");
        }

    }
}

namespace TaskManagerAPI.IOC
{
    public static class Injector
    {

        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<AssignmentRepository>();
        }

    }
}

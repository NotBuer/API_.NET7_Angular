namespace TaskManagerAPI.Extensions
{
    public static class DBConnectionUtils
    {

        private const string DEFAULT_CONNECTION = "DefaultConnection";

        public static WebApplicationBuilder BuilderAddDbContext(this WebApplicationBuilder builder)
        {
            string? connectionString = builder.Configuration.GetConnectionString(DEFAULT_CONNECTION);
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
            return builder;
        }

    }
}

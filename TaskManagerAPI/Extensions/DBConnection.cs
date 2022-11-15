namespace TaskManagerAPI.Extensions
{
    public static class DBConnection
    {

        private const string DEFAULT_CONNECTION = "DefaultConnection";
        private const string LOCAL_CONNECTION = "LocalConnection";

        public static WebApplicationBuilder BuilderAddDbContext(this WebApplicationBuilder builder)
        {
            string? connectionString = null;

            connectionString = builder.Environment.IsDevelopment() ?
                builder.Configuration.GetConnectionString(LOCAL_CONNECTION) : 
                builder.Configuration.GetConnectionString(DEFAULT_CONNECTION);
            
            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));
            return builder;
        }

    }
}

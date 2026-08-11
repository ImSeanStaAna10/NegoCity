using NegoCity.Application.Extensions;
using NegoCity.Infrastructure.Extensions;

namespace NegoCity.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApplicationServices();

            builder.Services.AddInfrastructure(
                builder.Configuration);

            builder.Services.AddControllers();

            var app = builder.Build();

            app.MapControllers();

            app.Run();
        }
    }
}
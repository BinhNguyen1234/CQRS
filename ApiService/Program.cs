using CQRS.Infrastructure.Database;
using CQRS.Middleware;
using Microsoft.EntityFrameworkCore;

namespace CQRS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>();
            builder.Services.AddControllers();
#if DEBUG
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
#endif

            builder.Services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
            });

            var app = builder.Build();


            app.UseMiddleware<HandleGlobalException>();

#if DEBUG
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
#endif
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            //app.Map("/api", configuration =>
            //{
            //    configuration.UseRouting();
            //    configuration.UseAuthorization();
            //    configuration.UseEndpoints(endpoints =>
            //    {
            //        endpoints.MapControllers();
            //    });
            //});

            app.MapControllers();

            app.Run();
        }
    }
}

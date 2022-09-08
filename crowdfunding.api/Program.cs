using crowdfunding.cmn.Services;
/* --------------------------------------------------------------------------------------------------- */
/* TO ADD */
/* --------------------------------------------------------------------------------------------------- */
using D = crowdfunding.dal;
using B = crowdfunding.bll;

namespace crowdfunding.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* --------------------------------------------------------------------------------------------------- */
            /* - ORIGINAL SCRIPT */
            /* --------------------------------------------------------------------------------------------------- */
            string allowOrigins = "AllowOrigins";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

                builder.Services.AddCors(options =>
                {
                    options.AddPolicy(allowOrigins, Policy =>
                    {
                        Policy.WithOrigins("*");
                    });
                });

                builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
            /* --------------------------------------------------------------------------------------------------- */
            /* - SERVICES TO ADD */
            /* --------------------------------------------------------------------------------------------------- */
                builder.Services.AddScoped<IProjectRepository<D.Entities.Project>, D.Services.ProjectService>();
                builder.Services.AddScoped<IProjectRepository<B.Entities.Project>, B.Services.ProjectService>();
            /* --------------------------------------------------------------------------------------------------- */
            /* - ORIGINAL SCRIPT */
            /* --------------------------------------------------------------------------------------------------- */
                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();

                app.UseCors(allowOrigins);

                app.UseAuthorization();

                app.MapControllers();

                app.Run();
        }
    }
}
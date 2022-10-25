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
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
                {
                    options.AddPolicy("AllowAll", Policy =>
                    {
                        Policy.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials();
                    });
                });

                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
            /* --------------------------------------------------------------------------------------------------- */
            /* - SERVICES TO ADD */
            /* --------------------------------------------------------------------------------------------------- */
            
                builder.Services.AddScoped<IProjectRepository<int, D.Entities.Project>, D.Services.ProjectService>();
                builder.Services.AddScoped<IProjectRepository<int, B.Entities.Project>, B.Services.ProjectService>();

                builder.Services.AddScoped<IUserRepository<D.Entities.User>, D.Services.UserService>();
                builder.Services.AddScoped<IUserRepository<B.Entities.User>, B.Services.UserService>();
            
            /* --------------------------------------------------------------------------------------------------- */
            
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
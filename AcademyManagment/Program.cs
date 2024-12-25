using AcademyManagment.Context;
using AcademyManagment.Entities;
using AcademyManagment.Repositories.Abstratcs;
using AcademyManagment.Repositories.Implements;
using AcademyManagment.Services;
using Microsoft.EntityFrameworkCore;
using SwaggerThemes;

namespace AcademyManagement;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.AddScoped<IStudentService, StudentService>();
        builder.Services.AddScoped<IRepository<Student>, Repository<Student>>();
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSql"));
        });

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(Theme.UniversalDark);
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

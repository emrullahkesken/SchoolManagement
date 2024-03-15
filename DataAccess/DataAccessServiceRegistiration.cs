using Business.Services;
using DataAccess.Contexts;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DataAccessServiceRegistiration
    {
        public static IServiceCollection AddDataAccessServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite(configuration.GetConnectionString("SqlCon"));
            });

            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<ILessonRepository, LessonRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<ITeacherRepository, TeacherRepository>();


            return services;
        }
    }
}

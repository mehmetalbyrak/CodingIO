using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyExtensions;

public static class AddRepositoryDependencyExtensions
{
    public static void AddRepositoryDependency(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<IInstructorDal, EfInstructorDal>();
        
        services.AddScoped<ICourseService, CourseManager>();
        services.AddScoped<ICourseDal, EfCourseDal>();
        
    }
}
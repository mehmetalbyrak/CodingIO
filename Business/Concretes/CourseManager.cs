using System.Runtime.InteropServices.ObjectiveC;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CourseManager: ICourseService
{
    
    ICourseDal _courseDal;
    ICategoryService _categoryService;
    IInstructorService _instructorService;
    
    public CourseManager(ICourseDal courseDal, ICategoryService categoryService, 
        IInstructorService instructorService)
    {
        _courseDal = courseDal;
        _categoryService = categoryService;
        _instructorService = instructorService;
    }
    
    
    public IDataResult<List<Course>> GetAll()
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetAll());
    }

    public IDataResult<List<Course>> GetById(int id)
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == id));
    }

    public IResult Add(Course course)
    {
        _courseDal.Add(course);
        return new SuccessResult(Messages.CourseAdded);
    }

    public IResult Update(Course course)
    {
        _courseDal.Update(course);
        return new SuccessResult(Messages.CourseUpdated);
    }

    public IResult Delete(Course course)
    {
        _courseDal.Delete(course);
        return new SuccessResult(Messages.CourseDeleted);
    }
}
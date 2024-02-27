using System.Collections.ObjectModel;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICourseService
{
    IDataResult<List<Course>> GetAll();
    IDataResult<List<Course>> GetById(int id);
    
    IResult Add(Course course);
    IResult Update(Course course);
    IResult Delete(Course course);
}